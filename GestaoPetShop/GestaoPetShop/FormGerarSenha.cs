﻿using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormGerarSenha : Form
    {
        string senhaAtual = "teste123";
        private int id;
        public FormGerarSenha(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (txtSenhaAtual.Text == senhaAtual)
            {
                DialogResult resposta = new DialogResult();
                resposta = MessageBox.Show("Deseja gerar a senha automaticamente?", "Alterar Senha",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    txtNovaSenha.Text = Senha.GerarSenha(8);
                    txtNovaSenha2.Text = txtNovaSenha.Text;
                }
                txtNovaSenha.Enabled = true;
                txtNovaSenha2.Enabled = true;
                btnOK.Enabled = true;
                txtNovaSenha.Focus();
            }
            else
            {
                MessageBox.Show("Senha atual inválida");
                txtSenhaAtual.Focus();
            }
        }

        private void checkBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrarSenha.Checked)
            {
                txtSenhaAtual.PasswordChar = '\u0000';
                txtNovaSenha.PasswordChar = '\u0000';
                txtNovaSenha2.PasswordChar = '\u0000';
            }
            else
            {
                txtSenhaAtual.PasswordChar = '*';
                txtNovaSenha.PasswordChar = '*';
                txtNovaSenha2.PasswordChar = '*';
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text == txtNovaSenha2.Text)
                MessageBox.Show("Senha alterada!\nAqui você salva a senha no banco de dados.");

            else
            {
                MessageBox.Show("A senha nova digitada não é igual da redigitação.");
                txtNovaSenha.Focus();
            }

            txtNovaSenha.Text = "";
            txtNovaSenha2.Text = "";
            txtSenhaAtual.Text = "";
            txtSenhaAtual.Focus();

            txtNovaSenha.Enabled = false;
            txtNovaSenha2.Enabled = false;
            btnOK.Enabled = false;
        }

        private void buttonSalvarNovaSenha_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();

                if(new UsuarioBLL().VerificarSenhaAtual(txtSenhaAtual.Text, ((Usuario)usuarioBindingSource.Current).Id))
                {
                    MessageBox.Show("Senha atual incorreta!");
                    txtSenhaAtual.Focus();
                    return;

                }

                usuario = (Usuario)usuarioBindingSource.Current;
                new UsuarioBLL().Alterar(usuario,txtNovaSenha2.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormGerarSenha_Load(object sender, EventArgs e)
        {
            
            usuarioBindingSource.AddNew();
            if(Constantes.IdUsuarioLogado != id)
            {
                MessageBox.Show("Você não tem permissão para alterar a senha deste Profissional");
                Close();
            }

            usuarioBindingSource.DataSource = new UsuarioBLL().BucarPorIdProfissional(id);
            txtNovaSenha.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
