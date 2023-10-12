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
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using static iText.Kernel.Pdf.Colorspace.PdfShading;

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
                string nomeArquivo = @"C:\dados\relatorioCliente"+ datahoje+".pdf";
                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                iTextSharp.text.pdf.PdfWriter escritorPDF = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, arquivoPDF);



                doc.Open();
                string dados = "";

                // inserindo um imagem

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\Users\ADM\Documents\GitHub\TEC.2022.1.105.Gestao-de-PetShop\GestaoPetShop\bicho-de-estimacao.png");
                logo.ScaleToFit(140f, 120); // tamanho da imagem
                logo.Alignment = Element.ALIGN_CENTER; // localização da imagem
                //logo.SetAbsolutePosition(100f, 700f); // outra forma localização da imagem


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


                // criação de tabelas

                PdfPTable tabela = new PdfPTable(6); // criação de tabela com três colunas
                tabela.DefaultCell.FixedHeight = 20; // altura da linha da tabela

                //PdfPCell celula1 = new PdfPCell(new Phrase("Tabela de preço"));
                //celula1.Colspan = 3; // mescla as três colunas da tabela na 1 linha
                //celula1.Rotation = 90; // rotaciona o texto na primeira linha
                //tabela.AddCell(celula1);

                // Cabeçalho na segunda linha, a escrita vai preenchedo por celula/linha quando uma
                // linha está completa ela passa para a outra dando continuidade
                
                
                tabela.AddCell("Id");
                tabela.AddCell("Nome");
                tabela.AddCell("Endereço");
                tabela.AddCell("Telefone");
                tabela.AddCell("E_mail");
                tabela.AddCell("Animal");

                List<Cliente> clientes = new List<Cliente>();
                clientes = new ClienteBLL().BuscarTodos();
                
                foreach (var item in clientes)
                {
                    
                    tabela.AddCell(Convert.ToString(item.Id));
                    tabela.AddCell(item.Nome);
                    tabela.AddCell("Rua: "+item.Logradouro+", Número:" + item.Numero+ ", Bairro "+item.Bairro+ ", Cidade: "+item.Cidade+ ", UF: "+item.UF+ ", CEP: "+item.CEP);
                    StringBuilder sb = new StringBuilder();
                    foreach (var tel in item.TelefoneClientes)
                    {
                        sb.Append(tel.Telefone);
                    }
                    string telefone = sb.ToString();
                    tabela.AddCell(telefone);

                    StringBuilder em = new StringBuilder();
                    foreach (var emails in item.EmailCliente)
                    {
                        em.Append(emails.Email);
                    }
                    string email = em.ToString();
                    tabela.AddCell(email);

                    StringBuilder an = new StringBuilder();
                    foreach (var animal in item.Animais)
                    {
                        an.Append(animal.Nome);
                    }
                    string ani = an.ToString();

                    tabela.AddCell(ani);

                }





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
    }
}
