using BLL;
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
    public partial class FormConsultaServico : Form
    {
        public FormConsultaServico()
        {
            InitializeComponent();
        }

        private void button_BucarServico_Click(object sender, EventArgs e)
        {
           
            try
            {
                ServicoBLL servicoBLL = new ServicoBLL();
                if (comboBox_EscolhaBuscarServico.SelectedIndex == 0)
                {
                 
                    servicoBindingSource.DataSource = servicoBLL.BuscarTodos();
                }

                if (comboBox_EscolhaBuscarServico.SelectedIndex == 1)
                {
                    
                    
                    servicoBindingSource.DataSource = servicoBLL.BuscarPorId(Convert.ToInt32(textBox_BuscarServico.Text));
                    
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
