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
        int id = 0; // serve para selecionar se é alterar Agenamento ou Cadastrar
        int opc = 0; //apenas para selecionar a opção correta de pequeisa em AgendamentoDAL

        AgendamentoServico agendamentoServicoExcluir = new AgendamentoServico();
        List<AgendamentoServico> servicosParaExcluir = new List<AgendamentoServico>();

        public FormCadastroAgendamento(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }


        private void FormCadastroAgendamento_Load(object sender, EventArgs e)
        {
            try
            {

                if (id == 0)
                    agendamentoBindingSource.AddNew();
                else
                    agendamentoBindingSource.DataSource = new AgendamentoBLL().BuscarAgendamentoPorId(id, opc);

            

                List<Profissional> agendamentoProfissinal = new List<Profissional>();

                List<Situacao> situacoes = new List<Situacao>();


                string _nomeProfissional = "";
                int _idProfissional = 0;
                agendamentoProfissinal = new AgendamentoBLL().BuscarPorNomeProfissional(_nomeProfissional, _idProfissional);
                int num2 = agendamentoProfissinal.Count();
                for (int x = 0; x < num2; x++)
                {
                    nomeProfissionalComboBox.Items.Insert(x, agendamentoProfissinal[x].Nome);
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

                    agendamentoBindingSource.DataSource = new AgendamentoBLL().BuscarAgendamentoPorId(id, opc);
                    
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            //    try
            //    {

            //        textBoxPrecoAplicado.Text = precoTextBox.Text;
            //        precoAplicado = Convert.ToDecimal(textBoxPrecoAplicado.Text);
            //        quantidade = Convert.ToInt32(textBoxQuantidade.Text);

            //        subtotal = quantidade * precoAplicado;
            //        textBoxSubtotal.Text = Convert.ToString(subtotal);
            //        atualizar = true;
            //    }
            //    catch (Exception ex)
            //    {

            //        MessageBox.Show(ex.Message);
            //    }
        }

        private void button_InserirServicoAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).Servico = descricaoComboBox.Text;
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).ValorUnitario = Convert.ToDecimal(precoTextBox.Text);

                agendamentoServicosBindingSource.EndEdit();
                Agendamento agendamento = (Agendamento)agendamentoBindingSource.Current;
                buttonNovo_Click(sender, e);
                agendamentoServicoDataGridView.Refresh();
                // return;

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
                agendamentoBindingSource.EndEdit();
                Agendamento agendamento = (Agendamento)agendamentoBindingSource.Current;

                if (id != 0)
                {
                    new AgendamentoBLL().Alterar(agendamento, servicosParaExcluir);
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

                        if (frm.Agendamento.IdCliente < 1)
                            return;

                        idAnimalTextBox.Text = Convert.ToString(frm.Agendamento.IdAnimal);
                        ((Agendamento)agendamentoBindingSource.Current).IdAnimal = frm.Agendamento.IdAnimal;
                        nomeAnimalTextBox.Text = frm.Agendamento.NomeAnimal;
                        ((Agendamento)agendamentoBindingSource.Current).NomeAnimal = frm.Agendamento.NomeAnimal;
                        idClienteTextBox.Text = Convert.ToString(frm.Agendamento.IdCliente);
                        ((Agendamento)agendamentoBindingSource.Current).IdCliente = frm.Agendamento.IdCliente;
                        nomeClienteTextBox.Text = frm.Agendamento.NomeCliente;
                        ((Agendamento)agendamentoBindingSource.Current).NomeCliente = frm.Agendamento.NomeCliente;
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
                Profissional profissionais = new AgendamentoBLL().BuscarProfissional(nomeProfissionalComboBox.Text);

                idProfissionalTextBox.Text = Convert.ToString(profissionais.Id);
                ((Agendamento)agendamentoBindingSource.Current).IdProfissional = profissionais.Id;
                nomeProfissionalComboBox.Text = profissionais.Nome;
                ((Agendamento)agendamentoBindingSource.Current).NomeProfissional = profissionais.Nome;
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
                Situacao situacao = new AgendamentoBLL().BuscarSituacaoPorNome(descricaoSituacaoComboBox.Text);
                idSituacaoTextBox.Text = Convert.ToString(situacao.Id);
                ((Agendamento)agendamentoBindingSource.Current).IdSituacao = situacao.Id;
                descricaoSituacaoComboBox.Text = situacao.Descricao;
                ((Agendamento)agendamentoBindingSource.Current).DescricaoSituacao = situacao.Descricao;
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


                int idservico = ((AgendamentoServico)agendamentoServicosBindingSource.Current).IdServico;
                if (idservico == 0)
                {
                    MessageBox.Show("Serviço inválido!");
                    return;
                }
                if (id != 0) // para alterar o serviço
                {

                    //  new AgendamentoBLL().ExcluirServicoDeAgendamento(idservico, idagendamento);

                    agendamentoServicoExcluir = (AgendamentoServico)agendamentoServicosBindingSource.Current;

                    servicosParaExcluir.Add(agendamentoServicoExcluir);
                    valortotalagendamento = Convert.ToDecimal(totalTextBox.Text);

                }
                subtotal = ((AgendamentoServico)agendamentoServicosBindingSource.Current).ValorTotal;

                valortotalagendamento = valortotalagendamento - subtotal;
                if (valortotalagendamento < 0)
                {
                    valortotalagendamento = 0;
                }
                totalTextBox.Text = Convert.ToString(valortotalagendamento);
                ((Agendamento)agendamentoBindingSource.Current).Total = valortotalagendamento;
                agendamentoServicosBindingSource.Remove(agendamentoServicosBindingSource.Current);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            groupBoxServico.Enabled = !groupBoxServico.Enabled;
            buttonNovo.Enabled = !buttonNovo.Enabled;

            if (!buttonNovo.Enabled)
            {
                agendamentoServicosBindingSource.AddNew();
                textBoxQuantidade.Text = "1";
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).Quantidade = 1;
                if (servicoBindingSource.Count == 0)
                    servicoBindingSource.DataSource = new ServicoBLL().BuscarTodos();
            }
        }

        private void textBoxPrecoAplicado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxSubtotal.Text = Convert.ToString(Convert.ToDecimal(textBoxPrecoAplicado.Text) * Convert.ToDecimal(textBoxQuantidade.Text));
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).ValorTotal = Convert.ToDecimal(textBoxPrecoAplicado.Text) * Convert.ToDecimal(textBoxQuantidade.Text);
            }
            catch (Exception)
            {

            }
        }

        private void precoTextBox_TextChanged(object sender, EventArgs e)
        {
            ((AgendamentoServico)agendamentoServicosBindingSource.Current).ValorComDesconto = Convert.ToDecimal(precoTextBox.Text);
        }
    }

}
