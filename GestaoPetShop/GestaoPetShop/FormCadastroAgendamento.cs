using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormCadastroAgendamento : Form
    {
        decimal subtotal;
        decimal valortotalagendamento = 0;
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
                {
                    agendamentoBindingSource.AddNew();
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

        private void button_InserirServicoAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).Servico = descricaoComboBox.Text;
               ///* textBoxValorUnitario.Text = precoTextBox.Text;
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).ValorUnitario = Convert.ToDecimal(precoTextBox.Text);
                ((AgendamentoServico)agendamentoServicosBindingSource.Current).IdServico = Convert.ToInt32(idTextBox.Text);
                agendamentoServicosBindingSource.EndEdit();

                Agendamento agendamento = (Agendamento)agendamentoBindingSource.Current;
                buttonNovo_Click(sender, e);
                agendamentoServicoDataGridView.Refresh();
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
                DateTime dataagendamento= ((Agendamento)agendamentoBindingSource.Current).DataAg;
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
                    //if (dataagendamento.Date < datahoje.Date)
                    //{
                    //    MessageBox.Show("Data inválida! \n Menor que a data atual.");
                    //    return;
                    //}

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
            ((AgendamentoServico)agendamentoServicosBindingSource.Current).ValorUnitario = Convert.ToDecimal(precoTextBox.Text);
            textBoxValorUnitario.Text = precoTextBox.Text;

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxValorUnitario_TextChanged(object sender, EventArgs e)
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

        private void descricaoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    //  servicoBindingSource.DataSource = new AgendamentoBLL().B(descricaoComboBox.Text);

            //    textBoxSubtotal.Text = Convert.ToString(Convert.ToDecimal(textBoxValorUnitario.Text) * Convert.ToDecimal(textBoxQuantidade.Text));
            //    //  ((AgendamentoServico)agendamentoServicosBindingSource.Current).Subtotal = Convert.ToDecimal(textBoxValorUnitario.Text) * Convert.ToDecimal(textBoxQuantidade.Text);

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
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
    }

}
