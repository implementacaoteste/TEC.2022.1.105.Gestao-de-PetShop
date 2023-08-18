using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormCadastroAgendamento : Form
    {
        internal decimal precoAplicado;
        decimal subtotal;
        int quantidade;
        decimal valortotalagendamento = 0;
        int quant = 0;
        bool atualizar = false;
        int id = 0;
        List<int> idservicoparaexcluir;
        public FormCadastroAgendamento(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }


        private void FormCadastroAgendamento_Load(object sender, EventArgs e)
        {
            try
            {

                List<AgendamentoServico> listViewServico = new List<AgendamentoServico>();

                listViewServico = new AgendamentoBLL().BuscarServicoPorNome(descricaoComboBox.Text);
                List<Agendamento> agendamentoProfissinal = new List<Agendamento>();
                List<Situacao> situacoes = new List<Situacao>();

                int num = listViewServico.Count();


                for (int x = 0; x < num; x++)
                {
                    descricaoComboBox.Items.Insert(x, listViewServico[x].Servico);
                }
                // método para combobox Profissional
                string _nomeProfissional = "";
                int _idProfissional = 0;
                agendamentoProfissinal = new AgendamentoBLL().BuscarPorNomeProfissional(_nomeProfissional, _idProfissional);
                int num2 = agendamentoProfissinal.Count();
                for (int x = 0; x < num2; x++)
                {
                    nomeProfissionalComboBox.Items.Insert(x, agendamentoProfissinal[x].NomeProfissional);
                }

                situacoes = new SituacaoBLL().BuscarTodos();
                int num3 = situacoes.Count();
                for (int x = 0; x < num3; x++)
                {
                    descricaoSituacaoComboBox.Items.Insert(x, situacoes[x].Descricao);

                }
                if (id != 0)
                {
                    Agendamento agendamento = new Agendamento();
                    agendamento = new AgendamentoBLL().BuscarAgendamentoPorId(id);
                    List<AgendamentoServico> agendamentoServicos = new List<AgendamentoServico>();
                    agendamentoServicos = agendamento.AgendamentoServicos;

                    idTextBox.Text = Convert.ToString(agendamento.Id);
                    dataAgDateTimePicker.Value = agendamento.DataAg;
                    horarioTextBox.Text = Convert.ToString(agendamento.Horario);
                    idSituacaoTextBox.Text = Convert.ToString(agendamento.IdSituacao);
                    descricaoSituacaoComboBox.Text = Convert.ToString(agendamento.DescricaoSituacao);
                    idAnimalTextBox.Text = Convert.ToString(agendamento.IdAnimal);
                    nomeAnimalTextBox.Text = Convert.ToString(agendamento.NomeAnimal);
                    idClienteTextBox.Text = Convert.ToString(agendamento.NomeCliente);
                    nomeClienteTextBox.Text = Convert.ToString(agendamento.NomeCliente);
                    idProfissionalTextBox.Text = Convert.ToString(agendamento.NomeProfissional);
                    nomeProfissionalComboBox.Text = Convert.ToString(agendamento.NomeProfissional);
                    totalTextBox.Text = Convert.ToString(agendamento.Total);
                    ativoCheckBox.Checked = Convert.ToBoolean(agendamento.Ativo);

                    foreach (AgendamentoServico item in agendamentoServicos)
                    {
                        agendamentoServicosBindingSource1.Add(item);
                    }
                   // agendamentoServicosBindingSource1.AddNew();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {

                textBoxPrecoAplicado.Text = precoTextBox.Text;
                precoAplicado = Convert.ToDecimal(textBoxPrecoAplicado.Text);
                quantidade = Convert.ToInt32(textBoxQuantidade.Text);

                subtotal = quantidade * precoAplicado;
                textBoxSubtotal.Text = Convert.ToString(subtotal);
                atualizar = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_InserirServicoAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (!atualizar)
                {
                    MessageBox.Show("Click em ATUALIZAR antes de INSERIR.");
                    return;
                }

                Agendamento agendamento = new Agendamento();
                agendamentoServicosBindingSource1.AddNew();
                ((AgendamentoServico)agendamentoServicosBindingSource1.Current).IdServico = Convert.ToInt32(idTextBox.Text);
                ((AgendamentoServico)agendamentoServicosBindingSource1.Current).Servico = descricaoComboBox.Text;
                ((AgendamentoServico)agendamentoServicosBindingSource1.Current).Quantidade = Convert.ToInt32(textBoxQuantidade.Text);
                ((AgendamentoServico)agendamentoServicosBindingSource1.Current).ValorUnitario = Convert.ToDecimal(precoTextBox.Text);
                ((AgendamentoServico)agendamentoServicosBindingSource1.Current).ValorComDesconto = Convert.ToDecimal(textBoxPrecoAplicado.Text);
                ((AgendamentoServico)agendamentoServicosBindingSource1.Current).ValorTotal = Convert.ToDecimal(textBoxSubtotal.Text);
                agendamentoServicosBindingSource1.EndEdit();
                quant = agendamentoBindingSource1.Count;
                subtotal = Convert.ToDecimal(textBoxSubtotal.Text);
                valortotalagendamento = valortotalagendamento + subtotal;
                totalTextBox.Text = Convert.ToString(valortotalagendamento);
                atualizar = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Agendamento agendamento = new Agendamento();
                List<AgendamentoServico> agendamentoServicos = new List<AgendamentoServico>();
                AgendamentoServico agendamentoServico = new AgendamentoServico();

                agendamento.DataAg = Convert.ToDateTime(dataAgDateTimePicker.Text);
                agendamento.Horario = Convert.ToString(horarioTextBox.Text);
                agendamento.IdSituacao = Convert.ToInt32(idSituacaoTextBox.Text);
                agendamento.IdAnimal = Convert.ToInt32(idAnimalTextBox.Text);
                agendamento.IdProfissional = Convert.ToInt32(idProfissionalTextBox.Text);
                agendamento.Ativo = ativoCheckBox.Checked;

                int quantidadeservicos = agendamentoServicosBindingSource1.Count;
                for (int x = 0; x < quantidadeservicos; x++)
                {
                    agendamentoServico.IdServico = ((AgendamentoServico)agendamentoServicosBindingSource1.Current).IdServico;
                    agendamentoServico.Quantidade = ((AgendamentoServico)agendamentoServicosBindingSource1.Current).Quantidade;
                    agendamentoServico.Servico = ((AgendamentoServico)agendamentoServicosBindingSource1.Current).Servico;
                    agendamentoServico.ValorComDesconto = ((AgendamentoServico)agendamentoServicosBindingSource1.Current).ValorComDesconto;
                    agendamentoServico.ValorTotal = ((AgendamentoServico)agendamentoServicosBindingSource1.Current).ValorTotal;
                    agendamentoServico.ValorUnitario = ((AgendamentoServico)agendamentoServicosBindingSource1.Current).ValorUnitario;

                    agendamentoServicos.Add(agendamentoServico);
                }
                agendamento.AgendamentoServicos = agendamentoServicos;

                if (id != 0)
                {
                    new AgendamentoBLL().Alterar(agendamento);
                }
                else
                {
                    new AgendamentoBLL().Inserir(agendamento);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

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
                        agendamento = agendamentoBLL.BuscarPorIdAnimalCliente(idpesquisa, opc);

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

        private void nomeProfissionalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string _nomeProfissional = nomeProfissionalComboBox.Text;
                int _idProfissional = 0;

                List<Agendamento> agendamentoProfissional = new List<Agendamento>();

                agendamentoProfissional = new AgendamentoBLL().BuscarPorNomeProfissional(_nomeProfissional, _idProfissional);

                foreach (Agendamento item in agendamentoProfissional)
                {
                    idProfissionalTextBox.Text = item.IdProfissional.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void descricaoSituacaoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Situacao situacao = new Situacao();
                List<Situacao> situacaos = new List<Situacao>();
                situacao = new AgendamentoBLL().BuscarSituacaoPorNome(descricaoSituacaoComboBox.Text);
                idSituacaoTextBox.Text = Convert.ToString(situacao.Id);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void descricaoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Servico servico = new Servico();
                servico = new AgendamentoBLL().PorNome(descricaoComboBox.Text);
                idTextBox.Text = Convert.ToString(servico.Id);
                descricaoComboBox.Text = servico.Descricao;
                precoTextBox.Text = Convert.ToString(servico.Preco);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void button1RemoverServico_Click(object sender, EventArgs e)
        {
            try
            {
                int idagendamento = Convert.ToInt32(idTextBox.Text);
                int idservico = ((AgendamentoServico)agendamentoServicosBindingSource1.Current).IdServico;
                if (idservico == 0)
                {
                    MessageBox.Show("Serviço inválido!");
                    return;
                }
                if (id != 0)
                {


                    new AgendamentoBLL().ExcluirServicoDeAgendamento(idservico, idagendamento);



                }
                subtotal = ((AgendamentoServico)agendamentoServicosBindingSource1.Current).ValorTotal;
                valortotalagendamento = valortotalagendamento - subtotal;
                totalTextBox.Text = Convert.ToString(valortotalagendamento);
                agendamentoServicosBindingSource1.Remove(agendamentoServicosBindingSource1.Current);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
