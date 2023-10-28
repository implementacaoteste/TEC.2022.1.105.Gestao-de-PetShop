﻿using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormsCadastroServico : Form
    {
        int id;
        public FormsCadastroServico(int _id = 0)
        {
            InitializeComponent();
            id = _id;
           
        }
        
        private void FormsCadastroServico_Load(object sender, EventArgs e)
        {
            LoadTheme();
            //this.Hide();
            try
            {
                if (id == 0)
                {
                    label1CadastrarServico.Visible = true;
                    label2_AlterarServico.Visible = false;
                    servicoBindingSource.AddNew();
                }
                else
                {
                    label1CadastrarServico.Visible = false;
                    label2_AlterarServico.Visible = true;
                    servicoBindingSource.DataSource = new ServicoBLL().BuscarPorId(id);
                }
                
                    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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

        private void button_SalvarServico_Click(object sender, EventArgs e)
        {
            try
            {
                servicoBindingSource.EndEdit();
                ServicoBLL servicoBLL = new ServicoBLL();
               
                if (id == 0)
                {
                    servicoBLL.Inserir((Servico)servicoBindingSource.Current);
                    MessageBox.Show("Cadastrado com sucesso!");
                    Close();
                }
                else
                {
                    servicoBLL.Alterar((Servico)servicoBindingSource.Current);
                    MessageBox.Show("Alterado com sucesso!");
                    Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_CancelarCadastroOuAlterar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tempoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }



    }
}
