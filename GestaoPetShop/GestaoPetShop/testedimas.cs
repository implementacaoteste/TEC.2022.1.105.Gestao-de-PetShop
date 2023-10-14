using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class testedimas : Form
    {
        class Eventos : PdfPageEventHelper

        {

            // propriedade da fonte que será usada no cabeçalho

            public iTextSharp.text.Font fonte { get; set; }



            // a classe recebe a fonte no seu construtor a classe não possui construtor padrão, para obrigar

            // a passagem da fonte e evitar erros

            public Eventos(iTextSharp.text.Font fonte_)

            {

                fonte = fonte_;

            }



            // Este método cria um cabeçalho para o documento

            public override void OnStartPage(PdfWriter writer, Document document)

            {

                // Cria um novo paragrafo com o texto do cabeçalho

                Paragraph ph = new Paragraph("Teste cabeçalho Pdf ", fonte);



                // adiciono a linha e posteriormente mais linhas que podem ser necessárias em um cabeçalho de relatório

                document.Add(ph);

                ph = new Paragraph("Teste Pdf 1 ", fonte);

                document.Add(ph);

                ph = new Paragraph("Teste Pdf 2 ", fonte);

                document.Add(ph);

                ph = new Paragraph("Teste Pdf 3 ", fonte);

                document.Add(ph);



                // cria um novo paragrafo para imprimir um traço e uma linha em branco

                ph = new Paragraph();



                // cria um objeto sepatador (um traço)

                iTextSharp.text.pdf.draw.VerticalPositionMark seperator = new iTextSharp.text.pdf.draw.LineSeparator();



                // adiciona o separador ao paragravo

                ph.Add(seperator);



                // adiciona a linha em branco(enter) ao paragrafo

                ph.Add(new Chunk("\n"));



                // imprime o pagagrafo no documento

                document.Add(ph);

            }



            public override void OnEndPage(PdfWriter writer, Document document)

            {

                // para o rodapé é um pouco diferente precisamos criar um PdfContentByte e uma BaseFont e

                // setar as propriedades dos mesmos para então poder imprimir alinhado a direita



                // cria uma instancia da classe PdfContentByte

                PdfContentByte cb = writer.DirectContent;



                // cria uma instancia da classe font

                BaseFont font;



                // seta as propriedades da fonte

                font = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.WINANSI, BaseFont.NOT_EMBEDDED);



                // seta a fonte do objeto PdfContentByte

                cb.SetFontAndSize(font, 9);



                // escreve a linha para imprimir o numero da página

                string texto = "Página: " + writer.PageNumber.ToString();



                // imprime a linha no rodapé

                cb.ShowTextAligned(Element.ALIGN_RIGHT, texto, document.Right, document.Bottom - 20, 0);

            }

        }

        public testedimas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document document = new Document();

            document.SetPageSize(PageSize.A4);

            try

            {

                // cria o arquivo pdf

                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(@"C:\dados\teste.pdf", FileMode.Create));



                // cria um objeto do tipo FontFamily, que contem as propriedades de uma fonte

                iTextSharp.text.Font.FontFamily familha = new iTextSharp.text.Font.FontFamily();



                // atribui a familia da fonte, no caso Courier

                familha = iTextSharp.text.Font.FontFamily.COURIER;



                // cria uma fonte atribuindo a familha, o tamanho da fonte e o estilo (normal, negrito...)

                iTextSharp.text.Font fonte = new iTextSharp.text.Font(familha, 8, (int)System.Drawing.FontStyle.Bold);



                // cria uma instancia da classe eventos, é uma classe que mostrarei posteriormente

                // esta clase trata a criação do cabeçalho e rodapé da página

                Eventos ev = new Eventos(fonte);



                // seta o atributo de eventos da classe com a variavel de eventos criada antes

                writer.PageEvent = ev;



                // altera a fonte para normal, a negrito era apenas para o cabeçalho e rodapé da página

                fonte = new iTextSharp.text.Font(familha, 8, (int)System.Drawing.FontStyle.Regular);



                // abre o documento para começar a escrever o pdf

                document.Open();



                // aqui faz um for para simular diversas linhas de um relatorio

                for (int i = 0; i < 100; i++)

                {

                    // adiciona um novo paragrafo com o texto da respectiva linha.

                    document.Add(new Paragraph("Teste linha", fonte));

                }

            }

            catch (Exception de)

            {

                MessageBox.Show(de.Message);

            }



            // fecha o documento

            document.Close();



            // manda abrir o pdf

            Process.Start(@"C:\dados\teste.pdf");
        }
    }
}
