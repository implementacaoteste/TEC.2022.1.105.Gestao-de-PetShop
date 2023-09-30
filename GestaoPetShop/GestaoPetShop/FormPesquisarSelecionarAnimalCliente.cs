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
        private int opc;
     
        public Cliente Cliente { get; set; }
        public Animal Animal { get; set; }
        public FormPesquisarSelecionarAnimalCliente()
        {
            InitializeComponent();
           
            this.Cliente = new Cliente();
            this.Animal = new Animal();
        }
        private void buttonBuscarAnimalCliente_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxEscolherTipoPequisaAnimalCliente.SelectedIndex)
                {
                    case 0: // buscar id animal
                        opc = 0;
                        if (String.IsNullOrEmpty(textBoxPesquisaAnimalCliente.Text))
                        {
                            MessageBox.Show("Digite o id do animal");
                            textBoxPesquisaAnimalCliente.Focus();
                            return;
                        }
                        clienteBindingSource.DataSource = new AgendamentoBLL().BuscarPorIdAnimalCliente(Convert.ToInt32(textBoxPesquisaAnimalCliente.Text), opc);
                        break;
                    case 1: // buscar id cliente
                        opc = 1;
                        if (String.IsNullOrEmpty(textBoxPesquisaAnimalCliente.Text))
                        {
                            MessageBox.Show("Digite o id do cliente");
                            textBoxPesquisaAnimalCliente.Focus();
                            return;
                        }
                        clienteBindingSource.DataSource = new AgendamentoBLL().BuscarPorIdAnimalCliente(Convert.ToInt32(textBoxPesquisaAnimalCliente.Text), opc);
                        break;
                    case 2: // buscar nome animal
                        opc = 2;
                        clienteBindingSource.DataSource = new AgendamentoBLL().BuscarPorNomeAnimalCliente(textBoxPesquisaAnimalCliente.Text, opc);
                        break;
                    case 3: // buscar nome cliente
                        opc = 3;
                        clienteBindingSource.DataSource = new AgendamentoBLL().BuscarPorNomeAnimalCliente(textBoxPesquisaAnimalCliente.Text, opc);
                        break;
                    case 4: // buscar todos
                        opc = 4;
                        clienteBindingSource.DataSource = new AgendamentoBLL().BuscarPorNomeAnimalCliente(textBoxPesquisaAnimalCliente.Text, opc);
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
                if (clienteBindingSource.Count > 0 & animaisBindingSource.Count > 0)
                {
                   
                    this.Cliente = (Cliente)clienteBindingSource.Current;
                    this.Animal = (Animal)animaisBindingSource.Current;
                    Close();
                }
                else
                {
                    MessageBox.Show("Não tem Animal selecionado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelarPesquisaAnimalCliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPesquisarSelecionarAnimalCliente_Load(object sender, EventArgs e)
        {
            comboBoxEscolherTipoPequisaAnimalCliente.SelectedIndex = 4;
            textBoxPesquisaAnimalCliente.Enabled = false;
        }

        private void comboBoxEscolherTipoPequisaAnimalCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEscolherTipoPequisaAnimalCliente.SelectedIndex != 4)
                textBoxPesquisaAnimalCliente.Enabled = true;
            else
                textBoxPesquisaAnimalCliente.Enabled = false;
        }
    }
}