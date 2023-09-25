using iText.Kernel.Pdf;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonRelatorio_Click(object sender, EventArgs e)
        {
            GerarPdf();
        }

        private void GerarPdf()
        {
            var arquivo = @"\GestaoPetShop\teste.pdf";
            var texto = "Usando como texte.";
            var data = "Araguaína - TO, 25 de setembro de 2023.";
            var assinatura = "______________________________";

            //using (PdfWriter wPdf = new PdfWriter(arquivo, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            //{
            //    var pdfDocument = new PdfDocument(wPdf);
            //    var document = new DocumentFont(pdfDocument, PageSize.A4);

            //    document.Add(new Paragraph("Isto é um parágrafo do PDF.");

                //document.SetFontSize(14);
                //document.SetMargins(50, 50, 50, 50);
                //document.SetCharacterSpacing(0.5f);

                //document.Add(new Paragraph("Curso de C#\n\n").SetFirstLineIndent(60).SetFontSize(20));

                ////var logo = @"\GestaoPetShop\bicho-de-estimacao.png";
                ////Image img = new Image

                //var timesNewRoman = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
                //var p1 = new Paragraph();
                //p1.SetFont(timesNewRoman);
                //p1.SetFontSize(30);
                //p1.SetTextAlignment(TextAlignment.CENTER);
                //p1.SetFontColor(ColorConstants.RED);
                //p1.SetBackgroundColor(ColorConstants.CYAN);
                //p1.Add("RECIBO");
                //document.Add(p1);

                //document.Close();
                //pdfDocument.Close();

                //MessageBox.Show("Arquivo PDF gerado em " + arquivo);


            //}
            //throw new NotImplementedException();
        }
    }
}
