using BLL;

using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static iText.Kernel.Pdf.Colorspace.PdfShading;
using Button = System.Windows.Forms.Button;

namespace GestaoPetShop
{
    public partial class FormRelatorioGeral : Form
    {
        class Eventos : PdfPageEventHelper

        {

            // propriedade da fonte que será usada no cabeçalho

            public iTextSharp.text.Font fonte { get; set; }
            public iTextSharp.text.Font fonte2 { get; set; }


            // a classe recebe a fonte no seu construtor a classe não possui construtor padrão, para obrigar

            // a passagem da fonte e evitar erros

            public Eventos(iTextSharp.text.Font fonte_, iTextSharp.text.Font fonte2_)

            {

                fonte = fonte_;
                fonte2 = fonte2_;

            }



            // Este método cria um cabeçalho para o documento

            public override void OnStartPage(iTextSharp.text.pdf.PdfWriter escritorPDF, Document doc)

            {

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\dados\bicho-de-estimacao.png");
                logo.ScaleToFit(70f, 50f); // tamanho da imagem
                logo.Alignment = Element.ALIGN_CENTER; // localização da imagem
                //logo.SetAbsolutePosition(100f, 700f); // outra forma localização da imagem
                doc.Add(logo);


                // Cria um novo paragrafo com o texto do cabeçalho

                iTextSharp.text.Paragraph ph = new iTextSharp.text.Paragraph("PetShop ",fonte);
               
                ph.Alignment = Element.ALIGN_CENTER;


                // adiciono a linha e posteriormente mais linhas que podem ser necessárias em um cabeçalho de relatório

                doc.Add(ph);

                ph = new iTextSharp.text.Paragraph("Cuidando do seu melhor amigo! ", fonte2);
             
                ph.Alignment = Element.ALIGN_CENTER;
                doc.Add(ph);



                // cria um novo paragrafo para imprimir um traço e uma linha em branco

                ph = new iTextSharp.text.Paragraph();



                // cria um objeto sepatador (um traço)

                iTextSharp.text.pdf.draw.VerticalPositionMark seperator = new iTextSharp.text.pdf.draw.LineSeparator();



                // adiciona o separador ao paragravo

                ph.Add(seperator);



                // adiciona a linha em branco(enter) ao paragrafo

                ph.Add(new Chunk("\n"));



                // imprime o pagagrafo no documento

                doc.Add(ph);

            }



            public override void OnEndPage(iTextSharp.text.pdf.PdfWriter escritorPDF, Document doc)

            {

                // para o rodapé é um pouco diferente precisamos criar um PdfContentByte e uma BaseFont e

                // setar as propriedades dos mesmos para então poder imprimir alinhado a direita



                // cria uma instancia da classe PdfContentByte
                PdfContentByte cb2 = escritorPDF.DirectContent;
                PdfContentByte cb = escritorPDF.DirectContent;



                // cria uma instancia da classe font
                BaseFont font2;
                BaseFont font;



                // seta as propriedades da fonte
                font2 = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.WINANSI, BaseFont.NOT_EMBEDDED);
                font = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.WINANSI, BaseFont.NOT_EMBEDDED);



                // seta a fonte do objeto PdfContentByte
                cb2.SetFontAndSize(font, 9);
                cb.SetFontAndSize(font, 9);



                // escreve a linha para imprimir o numero da página

                string texto2 = "Av. Dom Emanuel 1347, S/N, qd. H, lt. 1, Araguaína, TO, 77800-000,(63) 99200-0000";

                string texto = "Página: " + doc.PageNumber.ToString();



                // imprime a linha no rodapé
                cb2.ShowTextAligned(Element.ALIGN_JUSTIFIED, texto2, doc.Left, doc.Bottom - 10,0);
                cb.ShowTextAligned(Element.ALIGN_RIGHT, texto, doc.Right, doc.Bottom - 20, 0);

            }

        }
        public FormRelatorioGeral()
        {
            InitializeComponent();
        }

        private void buttonRelatorioCliente_Click(object sender, EventArgs e)
        {

            try
            {
                string datahoje = Convert.ToString(DateTime.Now);
                datahoje = datahoje.Replace("/", "");
                datahoje = datahoje.Replace(":", "");
                datahoje = datahoje.Replace(" ", "");
                string nomeArquivo = @"C:\dados\relatorioCliente" + datahoje + ".pdf";
                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);

                Document doc = new Document(PageSize.A4);
                iTextSharp.text.pdf.PdfWriter escritorPDF = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, arquivoPDF);


                // cria um objeto do tipo FontFamily, que contem as propriedades de uma fonte
                iTextSharp.text.Font.FontFamily familha = new iTextSharp.text.Font.FontFamily();

                // atribui a familia da fonte, no caso Courier
                familha = iTextSharp.text.Font.FontFamily.COURIER;

                // cria uma fonte atribuindo a familha, o tamanho da fonte e o estilo (normal, negrito...)
                iTextSharp.text.Font fonte = new iTextSharp.text.Font(familha, 12, (int)System.Drawing.FontStyle.Bold);
                iTextSharp.text.Font fonte2 = new iTextSharp.text.Font(familha, 10, (int)System.Drawing.FontStyle.Bold);


                // cria uma instancia da classe eventos, é uma classe que mostrarei posteriormente
                // esta clase trata a criação do cabeçalho e rodapé da página
                Eventos ev = new Eventos(fonte, fonte2);

                // seta o atributo de eventos da classe com a variavel de eventos criada antes
                escritorPDF.PageEvent = ev;

                // altera a fonte para normal, a negrito era apenas para o cabeçalho e rodapé da página

                fonte = new iTextSharp.text.Font(familha, 8, (int)System.Drawing.FontStyle.Regular);

                doc.Open();

                string dados = "";


                iTextSharp.text.Paragraph paragrafo = new iTextSharp.text.Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16, (int)System.Drawing.FontStyle.Bold));

                string titulo = "RELAÇÃO DE CLIENTES";
                paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add(titulo + " \n\n");


                PdfPTable tabela = new PdfPTable(7); // criação de tabela com três colunas
                tabela.DefaultCell.FixedHeight = 20; // altura da linha da tabela
                tabela.WidthPercentage = 100;
                tabela.HorizontalAlignment = 0;
                tabela.TotalWidth = 500f;
                float[] headerwidths = {11, 11, 40, 50, 30, 50, 20 };
                tabela.SetWidths(headerwidths);


                Chunk p1 = new Chunk("Ord", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                Phrase c1 = new Phrase();
                c1.Add(p1);
                PdfPCell celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;

                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Id", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Nome", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Endereço", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Telefone", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("E-mail", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Animal", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);

                /* Phrase*/
                c1 = new Phrase();

                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;

                celula1.VerticalAlignment = Element.ALIGN_CENTER;

                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                List<Cliente> clientes = new List<Cliente>();
                clientes = new ClienteBLL().BuscarTodos();
                int x = 1;
                foreach (var item in clientes)
                {

                    Chunk p2 = new Chunk(Convert.ToString(x++), FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    Phrase c2 = new Phrase();
                    c2.Add(p2);
                    PdfPCell celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    /*Chunk*/
                    p2 = new Chunk(Convert.ToString(item.Id), FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    /*Chunk*/
                    p2 = new Chunk(item.Nome, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    //tabela.AddCell(endereco);
                    string endereco = "Rua: " + item.Logradouro + ", Número:" + item.Numero + ", Bairro " + item.Bairro + ", Cidade: " + item.Cidade + ", UF: " + item.UF + ", CEP: " + item.CEP;
                    /*Chunk*/
                    p2 = new Chunk(endereco, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);


                    bool aux = false;
                    StringBuilder sb = new StringBuilder();
                    foreach (var tel in item.TelefoneClientes)
                    {
                        if (aux)
                            sb.Append(", ");

                        sb.Append(tel.Telefone);
                        aux = true;
                    }
                    string telefone = sb.ToString();
                    /*Chunk*/
                    p2 = new Chunk(telefone, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    aux = false;
                    StringBuilder em = new StringBuilder();
                    foreach (var emails in item.EmailCliente)
                    {
                        if (aux)
                            em.Append(", ");

                        em.Append(emails.Email);
                        aux = true;
                    }
                    string email = em.ToString();
                    /*Chunk*/
                    p2 = new Chunk(email, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    aux = false;
                    StringBuilder an = new StringBuilder();
                    foreach (var animal in item.Animais)
                    {
                        if (aux)
                            an.Append(", ");

                        an.Append(animal.Nome);
                        aux = true;
                    }
                    string ani = an.ToString();

                    /*Chunk*/
                    p2 = new Chunk(ani, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                }





                doc.Add(paragrafo);
                doc.Add(tabela);
                doc.Close();

                Process.Start(@"C:\dados\relatorioCliente" + datahoje + ".pdf");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

      

        private void btnTeste_Click(object sender, EventArgs e)
        {
            try
            {

                string nomeArquivo = @"C:\dados\relatorioCliente.pdf";
                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                iTextSharp.text.pdf.PdfWriter escritorPDF = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, arquivoPDF);



                doc.Open();
                string dados = "";

                iTextSharp.text.Paragraph paragrafo = new iTextSharp.text.Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));

                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add("Dimas Martins Mota \n");

                paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 18, (int)System.Drawing.FontStyle.Italic);
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add("Curso: Desenvolvimento de Sistemas \n");

                string email = "E-mail: dimasmartinsmota@hotmail.com";
                paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add(email + " \n");

                // inserindo um imagem

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\dados\trecoimagem.png");
                logo.ScaleToFit(140f, 120); // tamanho da imagem
                logo.Alignment = Element.ALIGN_LEFT; // localização da imagem
                //logo.SetAbsolutePosition(100f, 700f); // outra forma localização da imagem

                // criação de tabelas

                PdfPTable tabela = new PdfPTable(3); // criação de tabela com três colunas
                tabela.DefaultCell.FixedHeight = 20; // altura da linha da tabela

                PdfPCell celula1 = new PdfPCell(new Phrase("Tabela de preço"));
                celula1.Colspan = 3; // mescla as três colunas da tabela na 1 linha
                celula1.Rotation = 90; // rotaciona o texto na primeira linha
                tabela.AddCell(celula1);

                // Cabeçalho na segunda linha, a escrita vai preenchedo por celula/linha quando uma
                // linha está completa ela passa para a outra dando continuidade
                tabela.AddCell("Código");
                tabela.AddCell("Produto");
                tabela.AddCell("Preço");

                tabela.AddCell("01");
                tabela.AddCell("Mause");
                tabela.AddCell("25,00");
                tabela.AddCell("02");
                tabela.AddCell("Teclado");
                tabela.AddCell("65,00");





                doc.Add(logo);
                doc.Add(paragrafo);
                doc.Add(tabela);
                doc.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string datahoje = Convert.ToString(DateTime.Now);
                datahoje = datahoje.Replace("/", "");
                datahoje = datahoje.Replace(":", "");
                datahoje = datahoje.Replace(" ", "");
                string nomeArquivo = @"C:\dados\relacaoProfissionais" + datahoje + ".pdf";
                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);

                Document doc = new Document(PageSize.A4);
                iTextSharp.text.pdf.PdfWriter escritorPDF = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, arquivoPDF);


                // cria um objeto do tipo FontFamily, que contem as propriedades de uma fonte
                iTextSharp.text.Font.FontFamily familha = new iTextSharp.text.Font.FontFamily();

                // atribui a familia da fonte, no caso Courier
                familha = iTextSharp.text.Font.FontFamily.COURIER;

                // cria uma fonte atribuindo a familha, o tamanho da fonte e o estilo (normal, negrito...)
                iTextSharp.text.Font fonte = new iTextSharp.text.Font(familha, 12, (int)System.Drawing.FontStyle.Bold);
                iTextSharp.text.Font fonte2 = new iTextSharp.text.Font(familha, 10, (int)System.Drawing.FontStyle.Bold);


                // cria uma instancia da classe eventos, é uma classe que mostrarei posteriormente
                // esta clase trata a criação do cabeçalho e rodapé da página
                Eventos ev = new Eventos(fonte, fonte2);

                // seta o atributo de eventos da classe com a variavel de eventos criada antes
                escritorPDF.PageEvent = ev;

                // altera a fonte para normal, a negrito era apenas para o cabeçalho e rodapé da página

                fonte = new iTextSharp.text.Font(familha, 8, (int)System.Drawing.FontStyle.Regular);

                doc.Open();

                string dados = "";


                iTextSharp.text.Paragraph paragrafo = new iTextSharp.text.Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16, (int)System.Drawing.FontStyle.Bold));

                string titulo = "RELAÇÃO DE PROFISSIONAIS";
                paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add(titulo + " \n\n");


                PdfPTable tabela = new PdfPTable(7); // criação de tabela com três colunas
                tabela.DefaultCell.FixedHeight = 20; // altura da linha da tabela
                tabela.WidthPercentage = 100;
                tabela.HorizontalAlignment = 0;
                tabela.TotalWidth = 500f;
                float[] headerwidths = { 11,11, 40, 20, 50, 30, 40 };
                tabela.SetWidths(headerwidths);


                Chunk p1 = new Chunk("Ord", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                Phrase c1 = new Phrase();
                c1.Add(p1);
                PdfPCell celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;

                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Id", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Nome", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Função", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Endereço", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Telefone", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("E-mail", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);


                List<Profissional> profissionais = new List<Profissional>();
                profissionais = new ProfissionalBLL().BuscarTodos();
                int x = 1;
                foreach (var item in profissionais)
                {
                    bool aux = false; // variavel para auxiliar na separação de lista

                    Chunk p2 = new Chunk(Convert.ToString(x++), FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    Phrase c2 = new Phrase();
                    c2.Add(p2);
                    PdfPCell celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    /*Chunk*/
                    p2 = new Chunk(Convert.ToString(item.Id), FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    /*Chunk*/
                    p2 = new Chunk(item.Nome, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    
                    /*Chunk*/
                    p2 = new Chunk(item.NomeFuncao, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    //tabela.AddCell(endereco);
                    string endereco = "Rua: " + item.Logradouro + ", Número:" + item.Numero + ", Bairro " + item.Bairro + ", Cidade: " + item.Cidade + ", UF: " + item.UF + ", CEP: " + item.CEP;
                    /*Chunk*/
                    p2 = new Chunk(endereco, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);


                    aux = false;
                    StringBuilder sb = new StringBuilder();
                    foreach (var tel in item.TelefoneProfissional)
                    {
                        if (aux)
                            sb.Append(", ");

                        sb.Append(tel.Telefone);
                        aux = true;
                    }
                    string telefone = sb.ToString();
                    /*Chunk*/
                    p2 = new Chunk(telefone, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    aux = false;
                    StringBuilder em = new StringBuilder();
                    foreach (var emails in item.EmailProfissional)
                    {
                        if (aux)
                            em.Append(", ");

                        em.Append(emails.Email);
                        aux = true;
                    }
                    string email = em.ToString();
                    /*Chunk*/
                    p2 = new Chunk(email, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);
                }

                doc.Add(paragrafo);
                doc.Add(tabela);
                doc.Close();

                Process.Start(@"C:\dados\relacaoProfissionais" + datahoje + ".pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRelacaoDeAgendamentos_Click(object sender, EventArgs e)
        {
            try
            {
                string datahoje = Convert.ToString(DateTime.Now);
                datahoje = datahoje.Replace("/", "");
                datahoje = datahoje.Replace(":", "");
                datahoje = datahoje.Replace(" ", "");
                string nomeArquivo = @"C:\dados\relacaoDeAgendamentos" + datahoje + ".pdf";
                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);

                Document doc = new Document(PageSize.A4);
                iTextSharp.text.pdf.PdfWriter escritorPDF = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, arquivoPDF);


                // cria um objeto do tipo FontFamily, que contem as propriedades de uma fonte
                iTextSharp.text.Font.FontFamily familha = new iTextSharp.text.Font.FontFamily();

                // atribui a familia da fonte, no caso Courier
                familha = iTextSharp.text.Font.FontFamily.COURIER;

                // cria uma fonte atribuindo a familha, o tamanho da fonte e o estilo (normal, negrito...)
                iTextSharp.text.Font fonte = new iTextSharp.text.Font(familha, 12, (int)System.Drawing.FontStyle.Bold);
                iTextSharp.text.Font fonte2 = new iTextSharp.text.Font(familha, 10, (int)System.Drawing.FontStyle.Bold);


                // cria uma instancia da classe eventos, é uma classe que mostrarei posteriormente
                // esta clase trata a criação do cabeçalho e rodapé da página
                Eventos ev = new Eventos(fonte, fonte2);

                // seta o atributo de eventos da classe com a variavel de eventos criada antes
                escritorPDF.PageEvent = ev;

                // altera a fonte para normal, a negrito era apenas para o cabeçalho e rodapé da página

                fonte = new iTextSharp.text.Font(familha, 8, (int)System.Drawing.FontStyle.Regular);

                doc.Open();

                string dados = "";


                iTextSharp.text.Paragraph paragrafo = new iTextSharp.text.Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16, (int)System.Drawing.FontStyle.Bold));

                string titulo = "RELAÇÃO DE AGENDAMENTOS";
                paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add(titulo + " \n\n");


                PdfPTable tabela = new PdfPTable(9); // criação de tabela com três colunas
                tabela.DefaultCell.FixedHeight = 20; // altura da linha da tabela
                tabela.WidthPercentage = 100;
                tabela.HorizontalAlignment = 0;
                tabela.TotalWidth = 500f;
                float[] headerwidths = { 10, 10, 20, 20, 20, 40, 20,60,20 };
                tabela.SetWidths(headerwidths);


                Chunk p1 = new Chunk("Ord", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                Phrase c1 = new Phrase();
                c1.Add(p1);
                PdfPCell celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;

                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Id", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Data", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Horário", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Animal", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Cliente", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Situação", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Serviços", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);

                /* Chunk*/
                p1 = new Chunk("Total", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /* Phrase*/
                c1 = new Phrase();
                c1.Add(p1);
                /* PdfPCell*/
                celula1 = new PdfPCell();
                celula1.BackgroundColor = new iTextSharp.text.BaseColor(Color.Aqua);
                celula1.HorizontalAlignment = Element.ALIGN_CENTER;
                celula1.VerticalAlignment = Element.ALIGN_CENTER;
                celula1.AddElement(c1);
                tabela.AddCell(celula1);


                List<Agendamento> agendamentos = new List<Agendamento>();
                agendamentos = new AgendamentoBLL().BuscarTodos(0,1);
                int x = 1;
                Decimal valorTotalAgendamentos = 0;
                foreach (var item in agendamentos)
                {
                    bool aux = false; // variavel para auxiliar na separação de lista

                    Chunk p2 = new Chunk(Convert.ToString(x++), FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    Phrase c2 = new Phrase();
                    c2.Add(p2);
                    PdfPCell celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    /*Chunk*/
                    p2 = new Chunk(Convert.ToString(item.Id), FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    string dataagenda = Convert.ToString(item.DataAg.Date);
                    dataagenda = dataagenda.Remove(10);
                    /*Chunk*/
                    p2 = new Chunk(dataagenda, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);


                    /*Chunk*/
                    p2 = new Chunk(item.Horario, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    /*Chunk*/
                    p2 = new Chunk(item.NomeAnimal, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    /*Chunk*/
                    p2 = new Chunk(item.NomeCliente, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    /*Chunk*/
                    p2 = new Chunk(item.DescricaoSituacao, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    aux = false;
                    StringBuilder sb = new StringBuilder();
                    foreach (var servicos in item.AgendamentoServicos)
                    {
                        if (aux)
                            sb.Append(";\n ");

                        sb.Append("* "+servicos.Servico+ "- " + servicos.NomeProfissional + "- " + servicos.Subtotal);
                        aux = true;
                    }
                    string serv = sb.ToString();
                    /*Chunk*/
                    p2 = new Chunk(serv, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                   
                    /*Chunk*/
                    p2 = new Chunk(Convert.ToString(item.Total), FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/
                    c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/
                    celula2 = new PdfPCell();
                    celula2.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                    celula2.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula2.VerticalAlignment = Element.ALIGN_CENTER;
                    celula2.AddElement(c2);
                    tabela.AddCell(celula2);

                    valorTotalAgendamentos = valorTotalAgendamentos + item.Total;
                }

                Chunk p3 = new Chunk(("Valor Total dos agendamentos"), FontFactory.GetFont("Times New Roman"));
                p3.Font.Size = 8;
                p3.Font.SetStyle(0);
                p3.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /*Phrase*/
                Phrase c3 = new Phrase();
                c3.Add(p3);
                /*PdfPCell*/
                PdfPCell celula3 = new PdfPCell();
                celula3.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                celula3.HorizontalAlignment = Element.ALIGN_CENTER;
                celula3.VerticalAlignment = Element.ALIGN_CENTER;
                celula3.Colspan = 8;
                celula3.AddElement(c3);
                tabela.AddCell(celula3);

                p3 = new Chunk(Convert.ToString(valorTotalAgendamentos), FontFactory.GetFont("Times New Roman"));
                p3.Font.Size = 8;
                p3.Font.SetStyle(0);
                p3.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                /*Phrase*/
                c3 = new Phrase();
                c3.Add(p3);
                /*PdfPCell*/
                celula3 = new PdfPCell();
                celula3.BackgroundColor = new iTextSharp.text.BaseColor(Color.Transparent);
                celula3.HorizontalAlignment = Element.ALIGN_CENTER;
                celula3.VerticalAlignment = Element.ALIGN_CENTER;
              
                celula3.AddElement(c3);
                tabela.AddCell(celula3);

                doc.Add(paragrafo);
                doc.Add(tabela);
                doc.Close();

                Process.Start(@"C:\dados\relacaoDeAgendamentos" + datahoje + ".pdf");
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormRelatorioGeral_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
    }
}
