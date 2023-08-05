using BLL;
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
    public partial class ConsultaAgendamento : Form
    {
        string datahoje;
        public ConsultaAgendamento()
        {
            InitializeComponent();
            datahoje = monthCalendar_Agendamento.SelectionStart.ToShortDateString();
            textBox_BuscarData.Text = datahoje;
        }

        private void button_BuscarAgendamentos_Click(object sender, EventArgs e)
        {
            try
            {
                AgendamentoBLL agendamentoBLL = new AgendamentoBLL();
               
                if (comboBox_SelecionarTipoBusca.SelectedIndex == 0)
                {

                    dataGridView1_FormsPrincipalBindingSource.DataSource = agendamentoBLL.DataGridViewBuscarTodos();
                }

                else if (comboBox_SelecionarTipoBusca.SelectedIndex == 1)
                {

                    if (textBox_BuscarAgendamento.Text == "")
                    {
                        MessageBox.Show("Insirar um Id(código) do Agendamento para pesquisa");
                        return;
                    }
                    dataGridView1_FormsPrincipalBindingSource.DataSource = agendamentoBLL.DataGridViewBuscarPorId(Convert.ToInt32(textBox_BuscarAgendamento.Text));

                }
                else if (comboBox_SelecionarTipoBusca.SelectedIndex == 2)
                {

                    if(textBox_BuscarAgendamento.Text == "")
                    {
                        MessageBox.Show("Insirar o Nome do Animal para pesquisa");
                        return;
                    }
                    dataGridView1_FormsPrincipalBindingSource.DataSource = agendamentoBLL.BuscarPorNomeAnimal(textBox_BuscarAgendamento.Text);

                }
                else if(comboBox_SelecionarTipoBusca.SelectedIndex == 3)
                {
                    if (textBox_BuscarAgendamento.Text == "")
                    {
                        MessageBox.Show("Insirar o Nome do Cliente para pesquisa");
                        return;
                    }
                    dataGridView1_FormsPrincipalBindingSource.DataSource = agendamentoBLL.BuscarPorNomeCliente(textBox_BuscarAgendamento.Text);

                }
                else if (comboBox_SelecionarTipoBusca.SelectedIndex == 4)
                {
                    if (textBox_BuscarAgendamento.Text == "")
                    {
                        MessageBox.Show("Insirar o Nome do Cliente para pesquisa");
                        return;
                    }
                    dataGridView1_FormsPrincipalBindingSource.DataSource = agendamentoBLL.BuscarPorNomeCliente(textBox_BuscarAgendamento.Text);

                }
                else
                {
                    MessageBox.Show("Escolha a forma de busca");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_InserirAgendamentos_Click(object sender, EventArgs e)
        {
            //using(FormCadastroAgendamento frm = new FormCadastroAgendamento())
            //{
            //    frm.ShowDialog();
            //}
        }

        private void button_AbrirCalendario_Click(object sender, EventArgs e)
        {
            monthCalendar_Agendamento.Visible = true;
            button_SelecionarData.Visible = true;
        }

        private void button_SelecionarData_Click(object sender, EventArgs e)
        {
            textBox_BuscarData.Text = monthCalendar_Agendamento.SelectionStart.ToShortDateString();
            monthCalendar_Agendamento.Visible = false;
            button_SelecionarData.Visible = false;
        }
    }
}
