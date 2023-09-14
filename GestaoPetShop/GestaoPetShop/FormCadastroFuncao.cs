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
    public partial class FormCadastroFuncao : Form
    {
        int id;
        public FormCadastroFuncao(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }
        private void FormCadastroFuncao_Load(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                if (id == 0)
                {
                    funcaoBindingSource.AddNew();
                    lblCadastrarFuncao.Visible = true;
                    lblAlterarFuncao.Visible = false;

                }
                else
                {
                    lblCadastrarFuncao.Visible = false;
                    lblAlterarFuncao.Visible = true;
                    funcaoBindingSource.DataSource = new FuncaoBLL().BuscarPorId(id);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//Givas
        private void btnCancelarCadastroOuAlterar_Click(object sender, EventArgs e)
        {
            Close();
        }//Givas
        private void btnSalvarServico_Click(object sender, EventArgs e)
        {
            try
            {
                funcaoBindingSource.EndEdit();
                FuncaoBLL funcaoBLL = new FuncaoBLL();

                if (id == 0)
                {
                    funcaoBLL.Inserir((Funcao)funcaoBindingSource.Current);
                    MessageBox.Show("Cadastrado com Sucesso!");
                    Close();
                }
                else
                {
                    funcaoBLL.Alterar((Funcao)funcaoBindingSource.Current);
                    MessageBox.Show("Alterado com Sucesso!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//Givas
    }
}
