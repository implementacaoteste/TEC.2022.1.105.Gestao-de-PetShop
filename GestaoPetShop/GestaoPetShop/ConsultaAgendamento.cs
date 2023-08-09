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
                    string quant= textBox_BuscarData.Text;
                    if (textBox_BuscarData.Text == "" )
                    {
                        MessageBox.Show("Insirar o Data para pesquisa");
                        return;
                    }
                    
                    dataGridView1_FormsPrincipalBindingSource.DataSource = agendamentoBLL.BuscarPorDiaMesAno(textBox_BuscarData.Text);

                }
                else if (comboBox_SelecionarTipoBusca.SelectedIndex == 5 )
                {
                    if (textBox_BuscarData.Text == "")
                    {
                        MessageBox.Show("Insirar o Data para pesquisa");
                        return;
                    }
                    int opc = 5;
                    string qtd = textBox_BuscarData.Text;
                    int num = qtd.Count();
                    if (num == 7)
                    {
                        qtd = "01/" + textBox_BuscarData.Text;
                    }
                    else
                    {
                        qtd = textBox_BuscarData.Text;
                    }
                    dataGridView1_FormsPrincipalBindingSource.DataSource = agendamentoBLL.BuscarPorMesAno(opc,qtd);

                }
                else if (comboBox_SelecionarTipoBusca.SelectedIndex == 6)
                {
                    if (textBox_BuscarData.Text == "")
                    {
                        MessageBox.Show("Insirar o Data para pesquisa");
                        return;
                    }
                    int opc = 6;
                    string qtd = textBox_BuscarData.Text;
                    int num = qtd.Count();
                    if (num == 4)
                    {
                        qtd = "01/01/" + textBox_BuscarData.Text;
                    }
                    else if(num > 4 && num < 10)
                    {
                        MessageBox.Show("Insira o ano que deseja pesquisar");
                        textBox_BuscarData.Clear();
                    }
                    else
                    {
                        qtd = textBox_BuscarData.Text;
                    }
                    dataGridView1_FormsPrincipalBindingSource.DataSource = agendamentoBLL.BuscarPorMesAno(opc,qtd);

                }
                //else if (comboBox_SelecionarTipoBusca.SelectedIndex == 7)
                //{
                //    string quant = textBox_BuscarData.Text;
                //    if (textBox_BuscarData.Text == "")
                //    {
                //        MessageBox.Show("Insirar o Data para pesquisa");
                //        return;
                //    }

                //    dataGridView1_FormsPrincipalBindingSource.DataSource = agendamentoBLL.BuscarsServicoPorAno(textBox_BuscarData.Text);

                //}

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
            using (FormCadastroAgendamento frm = new FormCadastroAgendamento())
            {
                frm.ShowDialog();
            }
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
