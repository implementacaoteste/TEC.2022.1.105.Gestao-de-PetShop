using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace GestaoPetShop.Relatorio
{
    public partial class FormRelatorioCliente : Form
    {
        public FormRelatorioCliente()
        {
            InitializeComponent();
        }

        private void FormRelatorioCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelagemDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.modelagemDataSet.Cliente);
            this.reportViewer1.RefreshReport();
        }
    }
}
