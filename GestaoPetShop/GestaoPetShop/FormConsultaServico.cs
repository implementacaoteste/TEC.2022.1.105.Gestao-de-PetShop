using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormConsultaServico : Form
    {
        public FormConsultaServico()
        {
            InitializeComponent();
        }
        private void button_BucarServico_Click(object sender, EventArgs e)
        {

            try
            {
                ServicoBLL servicoBLL = new ServicoBLL();
                if (comboBox_EscolhaBuscarServico.SelectedIndex == 0)
                {

                    servicoBindingSource.DataSource = servicoBLL.BuscarTodos();
                }

                else if (comboBox_EscolhaBuscarServico.SelectedIndex == 1)
                {


                    servicoBindingSource.DataSource = servicoBLL.BuscarPorId(Convert.ToInt32(textBox_BuscarServico.Text));

                }
                else if (comboBox_EscolhaBuscarServico.SelectedIndex == 2)
                {


                    servicoBindingSource.DataSource = servicoBLL.BuscarPorNome(textBox_BuscarServico.Text);

                }
                else
                {
                    MessageBox.Show("Escolha a forma de busca");
                }

            }
            catch (System.FormatException ex)
            {
                if (textBox_BuscarServico.Text == "")
                {
                    MessageBox.Show("Id não informado \n" + ex.Message);
                    
                }
                else
                {

                    MessageBox.Show("Buscar por Id aceita apenas números \n " + ex.Message);
                }
                textBox_BuscarServico.Clear();
                textBox_BuscarServico.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void button_InserirServico_Click(object sender, EventArgs e)
        {
            int id = 0;
            using (FormsCadastroServico frm = new FormsCadastroServico(id))
            {
              
                    frm.ShowDialog();
            }
        }
        private void button_AlterarServico_Click(object sender, EventArgs e)
        {

            try
            {
                if (servicoBindingSource.Count == 0)
                {
                    MessageBox.Show("Não foi selecionado o Serviço para ser alterado.");
                    return;
                }
                int id = ((Servico)servicoBindingSource.Current).Id;

                using (FormsCadastroServico frm = new FormsCadastroServico(id))
                {
                    frm.ShowDialog();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_ExcluirServico_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (servicoBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro selecionado para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Servico)servicoBindingSource.Current).Id;
                new ServicoBLL().Excluir(id);
                servicoBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormConsultaServico_Load(object sender, EventArgs e)
        {
            comboBox_EscolhaBuscarServico.SelectedIndex = 0;
            textBox_BuscarServico.Enabled = false;


            LoadTheme();
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

        private void comboBox_EscolhaBuscarServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_EscolhaBuscarServico.SelectedIndex != 0)
                textBox_BuscarServico.Enabled = true;
            if (comboBox_EscolhaBuscarServico.SelectedIndex == 0)
            {
                textBox_BuscarServico.Clear();
                servicoBindingSource.Clear();
                textBox_BuscarServico.Enabled = false;
                textBox_BuscarServico.BackColor = Color.WhiteSmoke;
            }
            if (comboBox_EscolhaBuscarServico.SelectedIndex == 1)
            {
                textBox_BuscarServico.Clear();
                servicoBindingSource.Clear();
                textBox_BuscarServico.BackColor = Color.White;

            }
            if (comboBox_EscolhaBuscarServico.SelectedIndex == 2)
            {
                textBox_BuscarServico.Clear();
                servicoBindingSource.Clear();
                textBox_BuscarServico.BackColor = Color.White;

            }

        }
    }
}
