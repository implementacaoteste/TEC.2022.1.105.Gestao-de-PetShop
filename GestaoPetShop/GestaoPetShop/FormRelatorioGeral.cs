using BLL;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
        public FormRelatorioGeral()
        {
            InitializeComponent();
        }

        private void buttonRelatorioCliente_Click(object sender, EventArgs e)
        {
           
           
        GerarPdf();
        }

        private void GerarPdf()
        {
            try
            {
                string datahoje = Convert.ToString(DateTime.Now);
                datahoje = datahoje.Replace("/", "") ;
                datahoje = datahoje.Replace(":", "");
                datahoje = datahoje.Replace(" ", "");
                string nomeArquivo = @"C:\dados\relatorioCliente" + datahoje+".pdf";
                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                iTextSharp.text.pdf.PdfWriter escritorPDF = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, arquivoPDF);



                doc.Open();
                string dados = "";

                // inserindo um imagem

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\dados\bicho-de-estimacao.png");
                //iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\Users\ADM\Documents\GitHub\TEC.2022.1.105.Gestao-de-PetShop\GestaoPetShop\bicho-de-estimacao.png");
                logo.ScaleToFit(80f, 60f); // tamanho da imagem
                logo.Alignment = Element.ALIGN_CENTER; // localização da imagem
                //logo.SetAbsolutePosition(100f, 700f); // outra forma localização da imagem

                // CABEÇALHO
                iTextSharp.text.Paragraph paragrafo = new iTextSharp.text.Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16, (int)System.Drawing.FontStyle.Bold));

                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add("PetShop \n ");

                paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic);
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add("Cuidando do seu melhor amigo! \n\n");

                string titulo = "RELAÇÃO DE CLIENTES";
                paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add(titulo + " \n\n");

                //RODAPE
                iTextSharp.text.Paragraph paragrafo2 = new iTextSharp.text.Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Bold));

                paragrafo2.Alignment = Element.ALIGN_CENTER;
              
                paragrafo2.SetLeading(0, 50);

                paragrafo2.Add("Av. Dom Emanuel 1347, S/N, qd. H, lt. 1, Araguaína, TO, 77800-000,(63) 99200-0000  \n ");

                // criação de tabelas

                PdfPTable tabela = new PdfPTable(6); // criação de tabela com três colunas
                tabela.DefaultCell.FixedHeight = 20; // altura da linha da tabela
                tabela.WidthPercentage = 100;
                tabela.HorizontalAlignment = 0;
                tabela.TotalWidth = 500f;
                float[] headerwidths = { 10, 40, 50, 30, 50, 20 };
                tabela.SetWidths( headerwidths);


                //PdfPCell celula1 = new PdfPCell(new Phrase("Id"));
                //celula1.Padding = 2;
                //celula1.PaddingLeft = 5;
                //tabela.AddCell(celula1);

                Chunk p1 = new Chunk("Id", FontFactory.GetFont("Times New Roman"));
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

               /* Chunk*/ p1 = new Chunk("Nome", FontFactory.GetFont("Times New Roman"));
                p1.Font.Size = 10;
                p1.Font.SetStyle(0);
                p1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
               /* Phrase*/ c1 = new Phrase();
                c1.Add(p1);
               /* PdfPCell*/ celula1 = new PdfPCell();
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

                {
                    //tabela.AddCell(c1);
                    //for (int i = 1; i < 11; i++)
                    //{
                    //    celula1 = new PdfPCell(new Phrase(0, i.ToString());
                    //    celula1.FixedHeight = 15f;
                    //    celula1.Padding = 3;

                    //    tabela.AddCell(celula1);
                    //}

                    // Cabeçalho na segunda linha, a escrita vai preenchedo por celula/linha quando uma
                    // linha está completa ela passa para a outra dando continuidade
                } //teste

                //tabela.AddCell("Id");
                //tabela.AddCell("Nome");
                //tabela.AddCell("Endereço");
                //tabela.AddCell("Telefone");
                //tabela.AddCell("E_mail");
                //tabela.AddCell("Animal");

                List<Cliente> clientes = new List<Cliente>();
                clientes = new ClienteBLL().BuscarTodos();
                
                foreach (var item in clientes)
                {

                    Chunk p2 = new Chunk(Convert.ToString(item.Id), FontFactory.GetFont("Times New Roman"));
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

                    /*Chunk*/ p2 = new Chunk(item.Nome, FontFactory.GetFont("Times New Roman"));
                    p2.Font.Size = 8;
                    p2.Font.SetStyle(0);
                    p2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                    /*Phrase*/ c2 = new Phrase();
                    c2.Add(p2);
                    /*PdfPCell*/ celula2 = new PdfPCell();
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





                doc.Add(logo);
                doc.Add(paragrafo);
                doc.Add(tabela);
                doc.Add(paragrafo2);
                doc.Close();

                //abre O PDF no visualizador padrão Givas
                var caminhoPDF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo);
                if (File.Exists(caminhoPDF))
                {
                    Process.Start(new ProcessStartInfo()
                    {
                        Arguments = $"/c start {caminhoPDF}",
                        FileName = "cmd.exe",
                        CreateNoWindow = true
                    });
                }
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

        private void FormRelatorioGeral_Load(object sender, EventArgs e) //Givas
        {
            LoadTheme();
        }

        private void LoadTheme() // Givas
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
