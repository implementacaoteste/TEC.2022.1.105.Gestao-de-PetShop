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
    public partial class FormBuscarFuncao : Form
    {
        public FormBuscarFuncao()
        {
            InitializeComponent();
        }//Givasb
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Givas
        private void btnBuscarFuncao_Click(object sender, EventArgs e)
        {
            try
            {
                FuncaoBLL funcaoBLL = new FuncaoBLL();
                if (comboBoxEscolhaBuscarFuncao.SelectedIndex == 0)
                {
                    funcaoBindingSource.DataSource = funcaoBLL.BuscarTodos();
                }
                else if (comboBoxEscolhaBuscarFuncao.SelectedIndex == 1)
                {
                    funcaoBindingSource.DataSource = funcaoBLL.BuscarPorId(Convert.ToInt32(textBoxBuscarFuncao.Text));
                }
                else if(comboBoxEscolhaBuscarFuncao.SelectedIndex == 2)
                {
                    funcaoBindingSource.DataSource = funcaoBLL.BuscarPorNome(textBoxBuscarFuncao.Text);
                }
                else
                {
                    MessageBox.Show("Escolha a forma de busca");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//Givas
    }
}
