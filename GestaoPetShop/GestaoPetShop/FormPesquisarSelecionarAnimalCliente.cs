using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis.TtsEngine;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormPesquisarSelecionarAnimalCliente : Form
    {
        public int opc;
        public int id;
        public FormPesquisarSelecionarAnimalCliente()
        {
            InitializeComponent();
        }

        private void buttonBuscarAnimalCliente_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxEscolherTipoPequisaAnimalCliente.SelectedIndex)
                {
                    case 0:
                        opc = 1;
                        agendamentoBindingSource.DataSource = new AgendamentoBLL().DataGridViewBuscarPorId(Convert.ToInt32(textBoxPesquisaAnimalCliente.Text), opc);
                        break;
                    case 1:
                        opc = 2;
                        agendamentoBindingSource.DataSource = new AgendamentoBLL().DataGridViewBuscarPorId(Convert.ToInt32(textBoxPesquisaAnimalCliente.Text), opc);
                        break;
                    case 2:

                        agendamentoBindingSource.DataSource = new AgendamentoBLL().BuscarPorNomeAnimal(textBoxPesquisaAnimalCliente.Text);
                        break;
                    case 3:
                        agendamentoBindingSource.DataSource = new AgendamentoBLL().BuscarPorNomeCliente(textBoxPesquisaAnimalCliente.Text);
                        break;
                    default:
                        MessageBox.Show("Escolha Uma opção de busca");
                        break;

                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void buttonSelecionarAnimalCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (agendamentoBindingSource.Count > 0)

                {
                    switch (comboBoxEscolherTipoPequisaAnimalCliente.SelectedIndex)
                    {
                        case 0:

                             id = ((Agendamento)agendamentoBindingSource.Current).IdAnimal;
                             opc = 1;
                            break;
                        case 1:
                            id = ((Agendamento)agendamentoBindingSource.Current).IdCliente;
                            opc = 2;
                            break;
                       
                        default:
                            MessageBox.Show("Escolha um Tipo de pesquisa");
                            break;
                    }

                    Close();
                }
                else
                {
                    MessageBox.Show("Não tem Cliente/Animal selecionado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
