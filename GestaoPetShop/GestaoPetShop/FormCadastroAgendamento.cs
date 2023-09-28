﻿using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormCadastroAgendamento : Form
    {
        private decimal subtotal;
        private decimal valortotalagendamento = 0;
        private int id; // serve para selecionar se é alterar Agenamento ou Cadastrar
        private int opc = 0; //apenas para selecionar a opção correta de pequeisa em AgendamentoDAL

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
                {
                    agendamentoBindingSource.AddNew();
                    profissionalBindingSource.AddNew();

                    labelAlterarAgenda.Visible = false;
                    labelCadastroAgenda.Visible = true;

                }
                else
                {
                    agendamentoBindingSource.DataSource = new AgendamentoBLL().BuscarAgendamentoPorId(id, opc);
                    labelAlterarAgenda.Visible = true;
                    labelCadastroAgenda.Visible = false;
                }
          

                List<Profissional> agendamentoProfissinal = new List<Profissional>();
                string _nomeProfissional = "";
                int _idProfissional = 0;
                nomeProfissionalComboBox.Items.Clear();
                agendamentoProfissinal = new AgendamentoBLL().BuscarPorNomeProfissional(_nomeProfissional, _idProfissional);
                int num2 = agendamentoProfissinal.Count();
                for (int x = 0; x < num2; x++)
                {
                    nomeProfissionalComboBox.Items.Insert(x, agendamentoProfissinal[x].Nome);
                }


                List<Situacao> situacoes = new List<Situacao>();
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

        private void button_InserirServicoAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).Servico = descricaoComboBox.Text;
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).ValorUnitario = Convert.ToDecimal(textBoxValorUnitario.Text);
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).IdServico = Convert.ToInt32(idTextBox.Text);
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).IdProfissional = Convert.ToInt32(idProfissionalTextBox.Text);
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).NomeProfissional = nomeProfissionalComboBox.Text;
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).Quantidade = Convert.ToInt32(textBoxQuantidade.Text);
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).Tempo = ((Servico)servicoBindingSource.Current).Tempo;
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).Preco = Convert.ToDecimal(precoTextBox.Text);
                agendamentoServicosBindingSource.EndEdit();
              


                Agendamento agendamento = (Agendamento)agendamentoBindingSource.Current;
                buttonNovo_Click(sender, e);
                agendamentoServicosDataGridView.Refresh();

                valortotalagendamento = Convert.ToDecimal(totalTextBox.Text);
                subtotal = Convert.ToDecimal(textBoxSubtotal.Text);
                valortotalagendamento = valortotalagendamento + subtotal;
                totalTextBox.Text = Convert.ToString(valortotalagendamento);
                ((Agendamento)agendamentoBindingSource.Current).Total = valortotalagendamento;
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
                DateTime dataagendamento = ((Agendamento)agendamentoBindingSource.Current).DataAg;
                DateTime datahoje = DateTime.Now;
                agendamentoBindingSource.EndEdit();
                Agendamento agendamento = (Agendamento)agendamentoBindingSource.Current;

                if (id != 0)
                {
                    new AgendamentoBLL().Alterar(agendamento, servicosParaExcluir);
                    MessageBox.Show("Agendamento alterado com sucesso!");
                }
                else
                {

                    new AgendamentoBLL().Inserir(agendamento);
                    MessageBox.Show("Agendamento Cadastrado com sucesso!");
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

                        if (frm.Cliente.Id < 1)
                            return;

                        idAnimalTextBox.Text = Convert.ToString(frm.Animal.Id);
                        ((Agendamento)agendamentoBindingSource.Current).IdAnimal = frm.Animal.Id;
                        nomeAnimalTextBox.Text = frm.Animal.Nome;
                        ((Agendamento)agendamentoBindingSource.Current).NomeAnimal = frm.Animal.Nome;
                        idClienteTextBox.Text = Convert.ToString(frm.Cliente.Id);
                        ((Agendamento)agendamentoBindingSource.Current).IdCliente = frm.Cliente.Id;
                        nomeClienteTextBox.Text = frm.Cliente.Nome;
                        ((Agendamento)agendamentoBindingSource.Current).NomeCliente = frm.Cliente.Nome;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao tentar buscar Animal e Cliente no Banco de Dados\n" + ex.Message);
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
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).IdProfissional = profissionais.Id;
                nomeProfissionalComboBox.Text = profissionais.Nome;
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).NomeProfissional = profissionais.Nome;
                profissionalBindingSource.EndEdit();
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
                    agendamentoServicoExcluir = (AgendamentoServico)agendamentoServicosBindingSource.Current;
                    servicosParaExcluir.Add(agendamentoServicoExcluir);
                    valortotalagendamento = Convert.ToDecimal(totalTextBox.Text);
                }
                subtotal = ((AgendamentoServico)agendamentoServicosBindingSource.Current).Subtotal;

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


        private void precoTextBox_TextChanged(object sender, EventArgs e)
        {
            //((AgendamentoServico)agendamentoServicosBindingSource.Current).ValorUnitario = Convert.ToDecimal(precoTextBox.Text);
            textBoxValorUnitario.Text = precoTextBox.Text;

        }
              

        private void textBoxValorUnitario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxSubtotal.Text = Convert.ToString(Convert.ToDecimal(textBoxValorUnitario.Text) * Convert.ToDecimal(textBoxQuantidade.Text));
                //((AgendamentoServico)agendamentoServicosBindingSource.Current).Subtotal = Convert.ToDecimal(textBoxValorUnitario.Text) * Convert.ToDecimal(textBoxQuantidade.Text);
            }
            catch (Exception)
            {

            }
        }


        private void textBoxQuantidade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxSubtotal.Text = Convert.ToString(Convert.ToDecimal(textBoxValorUnitario.Text) * Convert.ToDecimal(textBoxQuantidade.Text));
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).Subtotal = Convert.ToDecimal(textBoxValorUnitario.Text) * Convert.ToDecimal(textBoxQuantidade.Text);
            }
            catch (Exception)
            {

            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void descricaoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Servico servico = new Servico();

                servico = new ServicoBLL().BuscarPorNomeUnico(descricaoComboBox.Text);

                ((Servico)servicoBindingSource.Current).Id = servico.Id;
                ((Servico)servicoBindingSource.Current).Descricao = servico.Descricao;
                ((Servico)servicoBindingSource.Current).Preco = servico.Preco;


                idTextBox.Text = Convert.ToString(servico.Id);
                descricaoComboBox.Text = servico.Descricao;
                precoTextBox.Text = Convert.ToString(servico.Preco);

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }

}
