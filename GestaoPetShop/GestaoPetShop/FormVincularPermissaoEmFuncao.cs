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
    public partial class FormVincularPermissaoEmFuncao : Form
    {
        public FormVincularPermissaoEmFuncao()
        {
            InitializeComponent();
        }

        private void buttonBuscarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
               
                switch (comboBoxSelecionarBuscaPermissao.TabIndex)
                {
                    case 0:
                        {
                            permissaoBindingSource.DataSource = new PermissaoBLL().BuscarTodos();
                            break;
                        }
                        case 1:
                        {
                            permissaoBindingSource.DataSource = new PermissaoBLL().BuscarPorId(Convert.ToInt32(textBoxBuscarPermissao.Text));
                            break;
                        }
                    case 2:
                        {
                            permissaoBindingSource.DataSource = new PermissaoBLL().BuscarPermissaoPorNome(textBoxBuscarPermissao.Text);
                            break;
                        }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
