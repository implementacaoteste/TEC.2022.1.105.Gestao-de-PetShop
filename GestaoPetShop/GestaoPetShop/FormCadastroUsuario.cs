using BLL;
using Models;
using System;
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
            try
            {
                if (Id == 0)
                {

                    usuarioBindingSource.AddNew();
                }
                else
                {

                    usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorId(Id);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                controle = 1;
            }
            else
            {
                senhaTextBox.UseSystemPasswordChar = true;
                controle = 0;
            }


        }
    }
}
