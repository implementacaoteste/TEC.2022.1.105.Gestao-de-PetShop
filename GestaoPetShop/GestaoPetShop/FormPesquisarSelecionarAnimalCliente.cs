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
                    case 0:
                        opc = 0;
                        clienteBindingSource.DataSource = new AgendamentoBLL().BuscarPorIdAnimalCliente(Convert.ToInt32(textBoxPesquisaAnimalCliente.Text), opc);
                        break;
                    case 1:
                        opc = 1;
                        clienteBindingSource.DataSource = new AgendamentoBLL().BuscarPorIdAnimalCliente(Convert.ToInt32(textBoxPesquisaAnimalCliente.Text), opc);
                        break;
                    case 2:
                        opc = 2;
                        clienteBindingSource.DataSource = new AgendamentoBLL().BuscarPorNomeAnimalCliente(textBoxPesquisaAnimalCliente.Text, opc);
                        break;
                    case 3:
                        opc = 3;
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
    }
}