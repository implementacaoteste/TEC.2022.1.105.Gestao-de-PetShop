using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //string caminho = string.Format("{0}/relatorio.pdf", txtDiretorio.Text); //incompleto

            //Document doc = new Document(PageSize.A4, 20, 20, 10, 10);
            //FileStream fs = new FileStream(caminho, FileMode.Create, FileAccess.Write, FileShare.None);
            //PdfWriter pdfWriter = PdfWriter.GetInstance(doc, fs);
            //doc.Open();

            //Paragraph p1 = new Paragraph(string.Format("Olá, {0}", txtNome.Text);
            //doc.Add(p1);

            //Paragraph p2 = new Paragraph("Qualquer texto digitado, como exemplo.");
            //doc.Add(p2);

            //Paragraph p3 = new Paragraph(string.Format("E-mail: {0}", txtEmail.Text);
            //doc.Add(p3);

            //doc.Close();
        }
    }
}
