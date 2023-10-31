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
    public partial class FormCadastroProfissional : Form
    {
        int id;
        bool permitirSalvar;
        public FormCadastroProfissional(int _id = 0, bool _permitirSalvar = true)
        {
            InitializeComponent();
            id = _id;
            buttonSalvar.Visible = _permitirSalvar;
            permitirSalvar = _permitirSalvar;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!permitirSalvar)
                    return;
                profissionalBindingSource.EndEdit();
                Profissional profissional = (Profissional)profissionalBindingSource.Current;

                if (id == 0)
                    new ProfissionalBLL().Inserir(profissional);
                else
                    new ProfissionalBLL().Alterar(profissional);

                MessageBox.Show("Registro salvo com sucesso.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormCadastroProfissional_Load(object sender, EventArgs e)
        {
            //this.Hide();
            try
            {
                LoadTheme();
                List<Funcao> funcoes = new List<Funcao>();
                funcoes = new FuncaoBLL().BuscarTodos();

                int num2 = funcoes.Count();
                for (int x = 0; x < num2; x++)
                {
                    nomeFuncaoComboBox.Items.Insert(x, funcoes[x].Nome);
                }

                if (id == 0)
                {
                    lblCadastrarProfissional.Visible = true;
                    lblAlterarProfissional.Visible = false;
                    profissionalBindingSource.AddNew();
                }

                else
                {
                    lblCadastrarProfissional.Visible = false;
                    lblAlterarProfissional.Visible = true;
                    profissionalBindingSource.AddNew();
                    btnGerarSenha.Visible = true;
                   
                     
                    profissionalBindingSource.DataSource = new ProfissionalBLL().BuscarPorId(id);



                }

                if (!permitirSalvar)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (!item.Name.Contains("DataGridView"))
                            item.Enabled = false;
                    }
                }

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }
        private void LoadTheme()
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao na função de colorir botões.", ex) { Data = { { "Id", 240 } } };
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            profissionalBindingSource.CancelEdit();
        }
        private void buttonBuscarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoDaImagem = openFileDialog.FileName;
                pictureBoxFoto.Image = Image.FromFile(caminhoDaImagem);
            }
        }
        private void buttonInserirEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxEmail.Text == "")
                {
                    MessageBox.Show("O campo do E-mail não estar preenchido.");
                    return;
                }
                emailProfissionalBindingSource.AddNew();
                ((EmailProfissional)emailProfissionalBindingSource.Current).Email = textBoxEmail.Text;
                emailProfissionalBindingSource.EndEdit();
                textBoxEmail.Text = "";

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar adicionar o e-mail do profissional no banco de dados.", ex) { Data = { { "Id", 241 } } };
            }

        }
        private void buttonInserirTelefone_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxTelefone.Text == "")
                {
                    MessageBox.Show("O campo do Telefone não estar preenchido.");
                    return;
                }
                telefoneProfissionalBindingSource.AddNew();
                ((TelefoneProfissional)telefoneProfissionalBindingSource.Current).Telefone = textBoxTelefone.Text;
                telefoneProfissionalBindingSource.EndEdit();
                textBoxTelefone.Text = "";

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar adicionar o telefone do profissional no banco de dados.", ex) { Data = { { "Id", 242 } } };
            }
        }
        private void buttonExcluirEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (profissionalBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro ?", "Atenção !", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((EmailProfissional)emailProfissionalBindingSource.Current).Id;
                new EmailProfissionalBLL().Excluir(id);
                emailProfissionalBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um E-mail do profissional no banco de dados.", ex) { Data = { { "Id", 243 } } };
            }
        }
        private void buttonExcluirTelefone_Click(object sender, EventArgs e)
        {
            try
            {
                if (profissionalBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }
                if (MessageBox.Show("Deseja realmente excluir este registro ?", "Atenção !", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((TelefoneProfissional)telefoneProfissionalBindingSource.Current).Id;
                new TelefoneProfissionalBLL().Excluir(id);
                telefoneProfissionalBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um Telefone do profissional no banco de dados.", ex) { Data = { { "Id", 244 } } };
            }
        }
        private void nomeFuncaoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Funcao> funcoes = new List<Funcao>();
            funcoes = new FuncaoBLL().BuscarPorNome(nomeFuncaoComboBox.Text);

            int num2 = funcoes.Count();
            for (int x = 0; x < num2; x++)
            {
                idFuncaoTextBox.Text = funcoes[x].Id.ToString();
                ((Profissional)profissionalBindingSource.Current).IdFuncao = Convert.ToInt32(funcoes[x].Id);
                //Insert(x, Convert.ToString(funcoes[x].Id));
            }
        }
        private void btnGerarSenha_Click(object sender, EventArgs e)
        {

            using (FormGerarSenha frm = new FormGerarSenha(id))
            {
                frm.ShowDialog();
            }
        }

        //private void textBoxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void cEPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}

        private void uFTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //private void textBoxDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}

        private void nomeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            nomeTextBox.Focus();
        }

        private void cPFTextBox_Click(object sender, EventArgs e)
        {
            cPFTextBox.SelectionStart = 0;
        }

        private void textBoxDataNascimento_Click(object sender, EventArgs e)
        {
            textBoxDataNascimento.SelectionStart = 0;
        }

        private void cEPTextBox_Click(object sender, EventArgs e)
        {
            cEPTextBox.SelectionStart = 0;
        }

        private void textBoxTelefone_Click(object sender, EventArgs e)
        {
            textBoxTelefone.SelectionStart = 0;
        }
    }
}
