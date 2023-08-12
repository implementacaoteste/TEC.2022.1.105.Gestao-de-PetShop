using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormCadastroAgendamento : Form
    {
        decimal precoAplicado;
        decimal subtotal;
        int quantidade;
        decimal valortotalagendamento = 0;

        public FormCadastroAgendamento()
        {
            InitializeComponent();
        }





        private void FormCadastroAgendamento_Load(object sender, EventArgs e)
        {
            try
            {

                List<AgendamentoServico> listViewServico = new List<AgendamentoServico>();

                listViewServico = new AgendamentoBLL().BuscarsServicoPorNome(descricaoComboBox.Text);



                int num = listViewServico.Count();
                MessageBox.Show(Convert.ToString(num));
                for (int x = 0; x < num; x++)
                {
                    descricaoComboBox.Items.Insert(x, listViewServico[x].Servico);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            servicoBindingSource.DataSource = new AgendamentoBLL().PorNome(descricaoComboBox.Text);
            textBoxPrecoAplicado.Text = precoTextBox.Text;
            precoAplicado = Convert.ToDecimal(textBoxPrecoAplicado.Text);
            quantidade = Convert.ToInt32(textBoxQuantidade.Text);

            subtotal = quantidade * precoAplicado;
            textBoxSubtotal.Text = Convert.ToString(subtotal);
        }

        private void button_InserirServicoAgendamento_Click(object sender, EventArgs e)
        {
            //List<AgendamentoServico> listAgendamentoServico = new List<AgendamentoServico>();
            //AgendamentoServico agendamentoServico;

            //agendamentoServico = new AgendamentoServico();
            //agendamentoServico.Id = Convert.ToInt32(idTextBox.Text);
            //agendamentoServico.Servico = descricaoComboBox.Text;
            //agendamentoServico.Quantidade = Convert.ToInt32(textBoxQuantidade.Text);
            //agendamentoServico.ValorUnitario = Convert.ToDecimal(precoTextBox.Text);
            //agendamentoServico.ValorComDesconto = Convert.ToDecimal(textBoxPrecoAplicado.Text);
            //agendamentoServico.ValorTotal = Convert.ToDecimal(textBoxSubtotal.Text);

            //listAgendamentoServico.Add(agendamentoServico);

            dataGridView_ServicoBindingSource.AddNew();
            ((AgendamentoServico)dataGridView_ServicoBindingSource.Current).IdServico = Convert.ToInt32(idTextBox.Text);
            ((AgendamentoServico)dataGridView_ServicoBindingSource.Current).Servico = descricaoComboBox.Text;
            ((AgendamentoServico)dataGridView_ServicoBindingSource.Current).Quantidade = Convert.ToInt32(textBoxQuantidade.Text);
            ((AgendamentoServico)dataGridView_ServicoBindingSource.Current).ValorUnitario = Convert.ToDecimal(precoTextBox.Text);
            ((AgendamentoServico)dataGridView_ServicoBindingSource.Current).ValorComDesconto = Convert.ToDecimal(textBoxPrecoAplicado.Text);
            ((AgendamentoServico)dataGridView_ServicoBindingSource.Current).ValorTotal = Convert.ToDecimal(textBoxSubtotal.Text);
            dataGridView_ServicoBindingSource.EndEdit();

            subtotal = Convert.ToDecimal(textBoxSubtotal.Text);
            valortotalagendamento = valortotalagendamento + subtotal;
            totalTextBox.Text = Convert.ToString(valortotalagendamento);

            //dataGridView_ServicoBindingSource.DataSource = listAgendamentoServico;


        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {



        }

        private void buttonPesquisarAnimal_Click(object sender, EventArgs e)
        {
            try
            {

                using (FormPesquisarSelecionarAnimalCliente frm = new FormPesquisarSelecionarAnimalCliente())
                {
                    try
                    {
                        frm.ShowDialog();
                        if (frm.id < 1)
                        {
                            return;
                        }
                        int opc = frm.opc;
                        int idpesquisa = frm.id;
                        AgendamentoBLL agendamentoBLL = new AgendamentoBLL();
                        Agendamento agendamento = new Agendamento();
                       // agendamento = agendamentoBLL.BuscarPorId(idpesquisa, opc);

                        idAnimalTextBox.Text = Convert.ToString(agendamento.IdAnimal);
                        nomeAnimalTextBox.Text = Convert.ToString(agendamento.NomeAnimal);
                        idClienteTextBox.Text = Convert.ToString(agendamento.IdCliente);
                        nomeClienteTextBox.Text = Convert.ToString(agendamento.NomeCliente);
                       
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao vincular Usuário em um grupo\n" + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
