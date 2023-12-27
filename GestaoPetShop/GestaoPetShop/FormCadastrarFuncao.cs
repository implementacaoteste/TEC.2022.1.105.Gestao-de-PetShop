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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace GestaoPetShop
{
    public partial class FormCadastrarFuncao : Form
    {
        private int Id;
        public FormCadastrarFuncao(int id = 0)
        {
            InitializeComponent();
            Id = id;
        }

        private void FormCadastrarFuncao_Load(object sender, EventArgs e)
        {

            this.Hide();
            try
            {
                LoadTheme();

                funcaoBindingSource.AddNew();
                if (Id == 0)
                {
                    lblCadastrarFuncao.Visible = true;
                    lblAlterarFuncao.Visible = false;

                }
                else
                {
                    lblCadastrarFuncao.Visible = false;
                    lblAlterarFuncao.Visible = true;
                    funcaoBindingSource.DataSource = new FuncaoBLL().BuscarPorId(Id);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw new Exception("Ocorreu um erro ao buscar uma função por ID no banco de dados.", ex) { Data = { { "Id", 236 } } };


            }
        }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                funcaoBindingSource.CancelEdit();
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                funcaoBindingSource.EndEdit();
                FuncaoBLL funcaoBLL = new FuncaoBLL();

                if (Id == 0)
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
        }
    }
}
