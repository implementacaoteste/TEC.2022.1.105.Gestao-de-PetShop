﻿using BLL;
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
    public partial class FormLogin : Form
    {
        public bool Logou;

        public FormLogin()
        {
            InitializeComponent();
           Logou = false;
        }
        
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().Altenticar(textBoxUsuario.Text, textBoxSenha.Text);
                Logou = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void textBoxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBoxSenha.Focus();
        }

        private void textBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonEntrar_Click(null, null);
        }
        
    }
}
