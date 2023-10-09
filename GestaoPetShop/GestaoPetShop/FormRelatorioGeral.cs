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

            string nomeArquivo = @"C:\dados\relatorioCliente.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            iTextSharp.text.pdf.PdfWriter escritorPDF = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, arquivoPDF);

            doc.Open();
            string dados = "";

            iTextSharp.text.Paragraph paragrafo = new iTextSharp.text.Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));

            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("Dimas Martins Mota \n");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL,18,(int)System.Drawing.FontStyle.Italic);
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("Curso: Desenvolvimento de Sistemas \n");

            string email="E-mail: dimasmartinsmota@hotmail.com";
            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Regular);
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add(email + " \n");

            doc.Add(paragrafo);
            doc.Close();


        }
    }
}
