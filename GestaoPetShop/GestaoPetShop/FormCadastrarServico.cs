using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormCadastrarServico : Form
    {
        private int Id;
        public FormCadastrarServico(int id = 0)
        {
            InitializeComponent();
            Id = id;
        }

        private void FormCadastrarServico_Load(object sender, EventArgs e)
        {
            try
            {

                LoadTheme();
                servicoBindingSource.AddNew();

                if (Id != 0)
                {
                    label1CadastrarServico.Visible = false;
                    label2_AlterarServico.Visible = true;
                    servicoBindingSource.DataSource = new ServicoBLL().BuscarPorId(Id);
                }
                else
                {
                    label1CadastrarServico.Visible = true;
                    label2_AlterarServico.Visible = false;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                servicoBindingSource.EndEdit();
                servicoBindingSource.Clear();
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                tempoTextBox_Click( sender, e);
                precoTextBox_Click(sender, e);

                servicoBindingSource.EndEdit();

                Servico servico = new Servico();

                servico = (Servico)servicoBindingSource.Current;

                if (Id == 0)
                {
                    new ServicoBLL().Inserir(servico);
                    MessageBox.Show("Serviço cadastrado com sucesso");
                }
                else
                {
                    new ServicoBLL().Alterar(servico);
                    MessageBox.Show("Serviço cadastrado com sucesso");
                }
                servicoBindingSource.Clear();
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }

        private void tempoTextBox_Click(object sender, EventArgs e)
        {
            if (tempoTextBox.Text == "" )
            {
                tempoTextBox.Text = "0";
            }
          
        }

        private void precoTextBox_Click(object sender, EventArgs e)
        {
            if (precoTextBox.Text == "")
            {
                precoTextBox.Text = "0";
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

        private void tempoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Aceita apenas números");
            }
        }
    }
}
