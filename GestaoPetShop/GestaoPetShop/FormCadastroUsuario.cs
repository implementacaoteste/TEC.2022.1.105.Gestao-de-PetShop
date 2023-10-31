using BLL;
using Models;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormCadastroUsuario : Form
    {
        public int Id;
        private int controle = 0;
        public FormCadastroUsuario(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
            senhaTextBox.UseSystemPasswordChar = true;


        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.EndEdit();

                if (Id == 0)
                    new UsuarioBLL().Inserir((Usuario)usuarioBindingSource.Current, textBoxConfirmarSenha.Text);
                else
                    new UsuarioBLL().Alterar((Usuario)usuarioBindingSource.Current, textBoxConfirmarSenha.Text);

                MessageBox.Show("Registro salvo com sucesso!");
                Close();

            }
            catch (Exception ex)
            {
                if (new TratarErro().GetId(ex) == 1)
                    senhaTextBox.Focus();

                MessageBox.Show(ex.Message);
            }
        }
        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                LoadTheme();

                if (Id == 0)
                {
                    label2CadastrarUsuario.Visible = true;
                    label4AlterarUsuario.Visible = false;
                    usuarioBindingSource.AddNew();
                }
                else
                {
                    label2CadastrarUsuario.Visible = false;
                    label4AlterarUsuario.Visible = true;
                    usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorId(Id);
                    senhaTextBox.Text = "";
                    textBoxConfirmarSenha.Text = "";
                    //
                    ToolTip toolTip1 = new ToolTip();
                    toolTip1.AutoPopDelay = 5000;
                    toolTip1.InitialDelay = 1000;
                    toolTip1.ReshowDelay = 500;
                    toolTip1.ShowAlways = true;
                    toolTip1.SetToolTip(this.buttonSalvar, "Eita treta");
                    toolTip1.SetToolTip(this.ativoCheckBox, "Opção que permitir ativar ou desativar um usuário no sistema");
                    toolTip1.SetToolTip(this.senhaTextBox, "Definir senha para acessar o sistema");
;               }

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
                throw new Exception("Ocorreu um erro ao tentar formatar um tema aos botões.", ex) { Data = { { "Id", 245 } } };
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void btnBuscarProfissional_Click(object sender, EventArgs e)
        {
            try
            {
                int opc = 1;
                using (FormConsultaProfissional frm = new FormConsultaProfissional(opc))
                {
                    frm.ShowDialog();
                    idTextBoxProfissional.Text = Convert.ToString(frm.id);
                    ((Usuario)usuarioBindingSource.Current).IdProfissional = frm.id;
                    nomeTextBoxProfissional.Text = frm.nome;
                    ((Usuario)usuarioBindingSource.Current).NomeProfissional = frm.nome;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {


            if (controle == 0)
            {
                senhaTextBox.UseSystemPasswordChar = false;
                textBoxConfirmarSenha.UseSystemPasswordChar = false;
                controle = 1;
            }
            else
            {
                senhaTextBox.UseSystemPasswordChar = true;
                textBoxConfirmarSenha.UseSystemPasswordChar=true;
                controle = 0;
            }


        }
    }
}
