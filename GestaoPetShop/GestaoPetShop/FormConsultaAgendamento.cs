using BLL;
using Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormConsultaAgendamento : Form
    {
        private string datahoje;
        public FormConsultaAgendamento()
        {
            InitializeComponent();
            datahoje = monthCalendar_Agendamento.SelectionStart.ToShortDateString();
            textBox_BuscarData.Text = datahoje;
        }
        private void button_BuscarAgendamentos_Click(object sender, EventArgs e)
        {
            try
            {
                int opcbusca; // variavel usada para selecionar a forma de busca dentro que um mesmo método em AgendamentoDAL
                int opcsituacao; // variavel para escolher a Situação do Agendamento (Todos,Agendado, Em andamento ou Finalizado)
                int opcativo; // variável para escolher e o Agendamento é Ativo, Inativo ou todos
                string dataconsulta;

                if (comboBox_SelecionarSituacaoBusca.SelectedIndex == 0)
                    opcsituacao = 0; // Todas as situações (agendado, em andamento, finalizado)

                else if (comboBox_SelecionarSituacaoBusca.SelectedIndex == 1)
                    opcsituacao = 1; // Situação agendado

                else if (comboBox_SelecionarSituacaoBusca.SelectedIndex == 2)
                    opcsituacao = 2; // Situação Em andamento

                else
                    opcsituacao = 3; // Finalizado


                if (comboBoxSelecionarAtivoBuscar.SelectedIndex == 0)
                    opcativo = 0; // Todos os agendamentos Ativos e Inativos

                else if (comboBoxSelecionarAtivoBuscar.SelectedIndex == 1)
                    opcativo = 1; // Agendamentos Ativos

                else
                    opcativo = 2; // Agendamentos Inativos


                AgendamentoBLL agendamentoBLL = new AgendamentoBLL();
                switch (comboBox_SelecionarTipoBusca.SelectedIndex)
                {
                    case 0: // BUSCAR TODOS OS AGENDAMENTOS
                        {
                            agendamentoBindingSource.DataSource = agendamentoBLL.BuscarTodos(opcsituacao, opcativo);
                            break;
                        }
                    case 1: // BUSCAR AGENDAMENTO POR ID
                        {
                            if (textBox_BuscarAgendamento.Text == "")
                            {
                                MessageBox.Show("Insirar um Id(código) do Agendamento para pesquisa");
                                return;
                            }
                            opcbusca = 0;
                            agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorId(Convert.ToInt32(textBox_BuscarAgendamento.Text), opcbusca);
                            break;
                        }
                    case 2:// BUSCAR AGENDAMENTO PELO NOME DO PROFISSIONAL
                        {

                            if (textBox_BuscarAgendamento.Text == "")
                            {
                                MessageBox.Show("Insirar o Nome do Profissional para pesquisa");
                                return;
                            }
                            agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorNomeProfissional(textBox_BuscarAgendamento.Text,opcativo,opcsituacao);
                            break;
                        }
                    case 3:// BUSCAR AGENDMAENTO PELO NOME DO CLIENTE CLIENTE
                        {

                            if (textBox_BuscarAgendamento.Text == "")
                            {
                                MessageBox.Show("Insirar o Nome do Cliente para pesquisa");
                                return;
                            }
                            agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorNomeCliente(textBox_BuscarAgendamento.Text, opcativo, opcsituacao);
                            break;
                        }
                    case 4: // BUSCAR AGENDAMENTO POR DIA/MÊS/ANO
                        {

                            dataconsulta = textBox_BuscarData.Text;
                            if (textBox_BuscarData.Text == ""|| dataconsulta.Count() != 10)
                            {
                                MessageBox.Show("Insirar o Data válida para pesquisa");
                                return;
                            }
                            opcbusca = 4;
                            agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorData(opcbusca, dataconsulta,opcativo,opcsituacao);
                            break;
                        }
                    case 5:// BUSCAR POR MÊS E ANO
                        {

                            if (textBox_BuscarData.Text == "")
                            {
                                MessageBox.Show("Insirar o Data para pesquisa");
                                return;
                            }
                            opcbusca = 5;
                            dataconsulta = textBox_BuscarData.Text;
                            if (dataconsulta.Count() == 7)
                            {
                                dataconsulta = "01/" + textBox_BuscarData.Text; // COMPLETAR O NUMERO DA DATA PARA A PESQUISA EM BD
                            }
                            else
                            {
                                dataconsulta = textBox_BuscarData.Text;
                            }
                            agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorData(opcbusca, dataconsulta, opcativo, opcsituacao);
                            break;
                        }
                    case 6: // BUSCAR POR ANO
                        {

                            if (textBox_BuscarData.Text == "")
                            {
                                MessageBox.Show("Insirar o Data para pesquisa");
                                return;
                            }
                            opcbusca = 6; // USADO PARA SELECIONAR EM AGENDAMENTODAL A FORMA DE BUSCA
                            dataconsulta = textBox_BuscarData.Text;
                            if (dataconsulta.Count() == 4)
                            {
                                dataconsulta = "01/01/" + textBox_BuscarData.Text;
                            }
                            else if (dataconsulta.Count() > 4 && dataconsulta.Count() < 10)
                            {
                                MessageBox.Show("Insira o ano que deseja pesquisar");
                                textBox_BuscarData.Clear();
                            }
                            else
                            {
                                dataconsulta = textBox_BuscarData.Text;
                            }
                            agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorData(opcbusca, dataconsulta, opcativo, opcsituacao);
                            break;
                        }
                    case 7:// BUSCAR AGENDAMENTO POR SERVICO DIA/MES/ANO
                        {

                            if (textBox_BuscarAgendamento.Text == "" || textBox_BuscarData.Text == "")
                            {
                                MessageBox.Show("Insira Serviço e a Data para pesquisa");
                                return;
                            }
                            opcbusca = 1;
                            agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorServicoData(textBox_BuscarAgendamento.Text, textBox_BuscarData.Text,opcbusca,opcativo,opcsituacao);
                            break;
                        }
                    case 8: // BUSCAR AGENDAMENTO POR SERVICO ANO
                        {

                            if (textBox_BuscarAgendamento.Text == "" || textBox_BuscarData.Text == "")
                            {
                                MessageBox.Show("Insira um Serviço e a Ano para pesquisa");
                                return;
                            }

                            dataconsulta = textBox_BuscarData.Text;
                            if (dataconsulta.Count() == 4)
                            {
                                dataconsulta = "01/01" + textBox_BuscarData.Text;
                            }
                            else if (dataconsulta.Count() > 4 && dataconsulta.Count() < 10)
                            {
                                MessageBox.Show("Insira o ano que deseja pesquisar");
                                textBox_BuscarData.Clear();
                            }
                            else
                            {
                                dataconsulta = textBox_BuscarData.Text;
                            }
                            opcbusca = 3;
                            agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorServicoData(textBox_BuscarAgendamento.Text, dataconsulta, opcbusca, opcativo, opcsituacao);
                            break;
                        }
                    case 9: // BUSCAR AGENDAMENTO POR SERVICO E MÊS/ANO
                        {

                            if (textBox_BuscarAgendamento.Text == "" || textBox_BuscarData.Text == "")
                            {
                                MessageBox.Show("Insira um Serviço, um mês e o Ano para pesquisa");
                                return;
                            }

                            dataconsulta = textBox_BuscarData.Text;
                            if (dataconsulta.Count() == 4)
                            {
                                dataconsulta = "01/01" + textBox_BuscarData.Text;
                            }
                            else if (dataconsulta.Count() > 4 && dataconsulta.Count() < 10)
                            {
                                MessageBox.Show("Insira o mês e o ano que deseja pesquisar");
                                textBox_BuscarData.Clear();
                            }
                            else
                            {
                                dataconsulta = textBox_BuscarData.Text;
                            }
                            opcbusca = 2;
                            agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorServicoData(textBox_BuscarAgendamento.Text, dataconsulta, opcbusca, opcativo, opcsituacao);
                            break;
                        }
                    case 10: // Busca por nome do serviço
                        {
                            if (textBox_BuscarAgendamento.Text == "")
                            {
                                MessageBox.Show("Insira um Serviço, um mês e o Ano para pesquisa");
                                textBox_BuscarAgendamento.Focus();
                                return;
                            }
                            agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorServico(textBox_BuscarAgendamento.Text, opcativo, opcsituacao);
                            break;
                        }
                    case 11: // BUSCAR POR PROFISSIONAL E DIA/MÊS/ANO
                        {
                            if (textBox_BuscarAgendamento.Text == "")
                            {
                                MessageBox.Show("Insira um Profissional para pesquisa");
                                textBox_BuscarAgendamento.Focus();
                                return;
                            }
                            if (textBox_BuscarData.Text == "")
                            {
                                MessageBox.Show("Insira a Data (Dia/Mês/Ano) para pesquisa");
                                textBox_BuscarData.Focus();
                                return;
                            }
                            dataconsulta = textBox_BuscarData.Text;

                            if (dataconsulta.Count() != 10)
                            {
                                MessageBox.Show("Insira a Data (Dia/Mês/Ano) para pesquisa");
                                textBox_BuscarData.Focus();
                                return;
                            }
                            opcbusca = 1;
                            agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorProfissionalData(textBox_BuscarAgendamento.Text, dataconsulta, opcbusca,opcativo,opcsituacao);
                        }
                        break;
                    case 12:// BUSCAR AGENDAMENTO POR PROFISSIONAL E MÊS/ANO
                        {
                            if (textBox_BuscarAgendamento.Text == "")
                            {
                                MessageBox.Show("Insira um Profissional para pesquisa");
                                textBox_BuscarAgendamento.Focus();
                                return;
                            }
                            if (textBox_BuscarData.Text == "")
                            {
                                MessageBox.Show("Insira a Data (Mês/Ano) para pesquisa");
                                textBox_BuscarData.Focus();
                                return;
                            }

                            dataconsulta = textBox_BuscarData.Text;
                            if (dataconsulta.Count() == 7)
                            {
                                dataconsulta = "01/" + textBox_BuscarData.Text;
                            }
                            else if (dataconsulta.Count() < 7 && dataconsulta.Count() > 10)
                            {
                                MessageBox.Show("Insira o Mês/Ano que deseja pesquisar");
                                textBox_BuscarData.Focus();
                                textBox_BuscarData.Clear();
                                return;
                            }
                            else
                            {
                                dataconsulta = textBox_BuscarData.Text;
                            }
                            opcbusca = 2; // USADO PARA SELECIONAR EM AGENDAMENTODAL A FORMA DE BUSCA
                            agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorProfissionalData(textBox_BuscarAgendamento.Text, dataconsulta, opcbusca,opcativo,opcsituacao);
                            break;
                        }
                    case 13:// BUSCAR AGENDAMENTO POR PROFISSIONAL E ANO
                        {

                            if (textBox_BuscarAgendamento.Text == "")
                            {
                                MessageBox.Show("Insira um Profissional para pesquisa");
                                textBox_BuscarAgendamento.Focus();
                                return;
                            }
                            if (textBox_BuscarData.Text == "")
                            {
                                MessageBox.Show("Insira a Data (Mês/Ano) para pesquisa");
                                textBox_BuscarData.Focus();
                                return;
                            }

                            dataconsulta = textBox_BuscarData.Text;
                            if (dataconsulta.Count() == 4)
                            {
                                dataconsulta = "01/01/" + textBox_BuscarData.Text;
                            }
                            else if (dataconsulta.Count() > 4 && dataconsulta.Count() < 10)
                            {
                                MessageBox.Show("Insira o Mês/Ano que deseja pesquisar");
                                textBox_BuscarData.Focus();
                                textBox_BuscarData.Clear();
                                return;
                            }
                            else
                            {
                                dataconsulta = textBox_BuscarData.Text;
                            }
                            opcbusca = 3; // USADO PARA SELECIONAR EM AGENDAMENTODAL A FORMA DE BUSCA
                            agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorProfissionalData(textBox_BuscarAgendamento.Text, dataconsulta, opcbusca, opcativo, opcsituacao);
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Escolha a forma de busca");
                            comboBox_SelecionarTipoBusca.Focus();
                            break;
                        }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_AbrirCalendario_Click(object sender, EventArgs e)
        {
            try
            {
                monthCalendar_Agendamento.Visible = true;
                button_SelecionarData.Visible = true;
                buttonFecharCalendario.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o calendário", ex.Message);
            }
        }
        private void button_SelecionarData_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_BuscarData.Text = monthCalendar_Agendamento.SelectionStart.ToShortDateString();
                monthCalendar_Agendamento.Visible = false;
                button_SelecionarData.Visible = false;
                buttonFecharCalendario.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar selecionar uma data no calendário.", ex.Message);
            }
        }
        private void button_InserirAgendamentos_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                using (FormCadastroAgendamento frm = new FormCadastroAgendamento(id))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_AlterarAgendamentos_Click(object sender, EventArgs e)
        {
            try
            {
                if (agendamentoBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não foi selecionado o Agendamento para ser alterado.");
                    return;
                }
                int id = ((Agendamento)agendamentoBindingSource.Current).Id;
                using (FormCadastroAgendamento frm = new FormCadastroAgendamento(id))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_ExcluirAgendamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (agendamentoBindingSource.Count < 1)
                {
                    MessageBox.Show("Selecione um Agendamento para ser excluido.");
                }
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                Agendamento agendamento = (Agendamento)agendamentoBindingSource.Current;
                new AgendamentoBLL().Excluir(agendamento);
                agendamentoBindingSource.RemoveCurrent();
                MessageBox.Show("Registro excluido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonFecharCalendario_Click(object sender, EventArgs e)
        {
            try
            {
                monthCalendar_Agendamento.Visible = false;
                button_SelecionarData.Visible = false;
                buttonFecharCalendario.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar fecha o calendário.", ex.Message);
            }
        }
    }
}