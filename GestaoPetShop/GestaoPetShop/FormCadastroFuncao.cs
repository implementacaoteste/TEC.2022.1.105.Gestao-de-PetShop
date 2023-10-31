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
                LoadTheme();

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
                //MessageBox.Show(ex.Message);
                throw new Exception("Ocorreu um erro ao buscar uma função por ID no banco de dados.", ex) { Data = { { "Id", 236 } } };


            }
        }//Givas
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
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
