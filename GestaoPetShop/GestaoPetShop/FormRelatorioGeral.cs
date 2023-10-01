using BLL;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
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
            
            //Document doc = new Document(PageSize.A4);//criando e            estipulando o tipo da folha usada
            //doc.SetMargins(40, 40, 40, 80);//estibulando o           espaçamento das margens que queremos
            //doc.AddCreationDate();//adicionando as configuracoes

            ////caminho onde sera criado o pdf + nome desejado
            ////OBS: o nome sempre deve ser terminado com .pdf

            //string str = Convert.ToString(DateTime.Now);
            //string[] charsToRemove = new string[] { "@", ",", ".", ";", "'","/",":"};
            //foreach (var c in charsToRemove)
            //{
            //    str = str.Replace(c, string.Empty);
            //}



            //string caminho = @"C:\dados\";
            //caminho = caminho + str;
            //caminho = caminho + "Eita.pdf";
            
          
            ////criando o arquivo pdf embranco, passando como parametro            a variavel
            ////doc criada acima e a variavel caminho
            ////tambem criada acima.
            //iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
            //doc.Open();

            ////criando uma string vazia
            //string dados = "";

            ////criando a variavel para paragrafo
            //Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14));
            
            ////etipulando o alinhamneto
            //paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
          
            ////Alinhamento Justificado
            //paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);
           
            ////paragrafo.Add("TESTE TESTE TESTE");

            //List<Cliente> clientes = new List<Cliente>();
            //clientes = new ClienteBLL().BuscarTodos();
            
            ////doc.Add(paragrafo);



            //foreach (var item in clientes)
            //{
            //    paragrafo = new Paragraph(); 
            //    paragrafo.Add(@"Id: "+item.Id + 
            //   "\nNome: " + item.Nome +
            //   "\nData de nascimento: " + item.DataNascimento +
            //   "\n CPF: " + item.CPF+ "\n");
               
            //    doc.Add(paragrafo);
            //}
          

            ////acidionado paragrafo ao documento
         
           
            //fechando documento para que seja salva as      alteraçoes.
            //doc.Close();
        }
    }
}
