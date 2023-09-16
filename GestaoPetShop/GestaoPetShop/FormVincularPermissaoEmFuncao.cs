using BLL;
using Models;
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
       
        
        public FormVincularPermissaoEmFuncao(int _id, string _nomeFuncao)
        {
            InitializeComponent();
            textBoxIdFuncao.Text = Convert.ToString( _id);
            textBoxFuncao.Text = _nomeFuncao;
            

        }

        private void buttonBuscarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
               
                switch (comboBoxSelecionarBuscaPermissao.SelectedIndex)
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

        private void buttonInserirPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                if(permissaoBindingSource.Count < 1)
                {
                    MessageBox.Show("Selecione uma permissão para ser inserida na função");
                    return;
                }
                int idfuncao = Convert.ToInt32(textBoxIdFuncao.Text);
                int idpermissao = ((Permissao)permissaoBindingSource.Current).Id;

                new FuncaoBLL().InserirPermissaoNaFuncao(idfuncao, idpermissao);

                MessageBox.Show("Permissão inserida com sucesso");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
