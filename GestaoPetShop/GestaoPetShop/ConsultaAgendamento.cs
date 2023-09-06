using BLL;
using Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class ConsultaAgendamento : Form
    {
        private string datahoje;
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
                switch (comboBox_SelecionarTipoBusca.SelectedIndex)
                {
                    case 0: // BUSCAR TODOS OS AGENDAMENTOS
                        int opc; // variavel usada para selecionar a forma de busca em AgenndamentoDAL

                        string dataconsulta;

                        agendamentoBindingSource.DataSource = agendamentoBLL.BuscarTodos();
                        break;
                    case 1: // BUSCAR AGENDAMENTO POR ID

                        if (textBox_BuscarAgendamento.Text == "")
                        {
                            MessageBox.Show("Insirar um Id(código) do Agendamento para pesquisa");
                            return;
                        }
                        opc = 0;
                        agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorId(Convert.ToInt32(textBox_BuscarAgendamento.Text), opc);
                        break;
                    case 2:// BUSCAR AGENDAMENTO PELO NOME DO PROFISSIONAL
                        if (textBox_BuscarAgendamento.Text == "")
                        {
                            MessageBox.Show("Insirar o Nome do Profissional para pesquisa");
                            return;
                        }
                        agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorNomeProfissional(textBox_BuscarAgendamento.Text);
                        break;
                    case 3:// BUSCAR AGENDMAENTO PELO NOME DO CLIENTE CLIENTE
                        if (textBox_BuscarAgendamento.Text == "")
                        {
                            MessageBox.Show("Insirar o Nome do Cliente para pesquisa");
                            return;
                        }
                        agendamentoBindingSource.DataSource = agendamentoBLL.BuscarPorNomeCliente(textBox_BuscarAgendamento.Text);
                        break;
                    case 4: // BUSCAR AGENDAMENTO POR DIA/MÊS/ANO

                        if (textBox_BuscarData.Text == "")
                        {
                            MessageBox.Show("Insirar o Data para pesquisa");
                            return;
                        }
                        agendamentoBindingSource.DataSource = agendamentoBLL.BuscarPorDiaMesAno(textBox_BuscarData.Text);
                        break;
                    case 5:// BUSCAR POR MÊS E ANO
                        if (textBox_BuscarData.Text == "")
                        {
                            MessageBox.Show("Insirar o Data para pesquisa");
                            return;
                        }
                        opc = 5;
                        dataconsulta = textBox_BuscarData.Text;
                        if (dataconsulta.Count() == 7)
                        {
                            dataconsulta = "01/" + textBox_BuscarData.Text; // COMPLETAR O NUMERO DA DATA PARA A PESQUISA EM BD
                        }
                        else
                        {
                            dataconsulta = textBox_BuscarData.Text;
                        }
                        agendamentoBindingSource.DataSource = agendamentoBLL.BuscarPorMesAno(opc, dataconsulta);
                        break;
                    case 6: // BUSCAR POR ANO
                        if (textBox_BuscarData.Text == "")
                        {
                            MessageBox.Show("Insirar o Data para pesquisa");
                            return;
                        }
                        opc = 6; // USADO PARA SELECIONAR EM AGENDAMENTODAL A FORMA DE BUSCA
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
                        agendamentoBindingSource.DataSource = agendamentoBLL.BuscarPorMesAno(opc, dataconsulta);
                        break;
                    case 7:// BUSCAR AGENDAMENTO POR SERVICO DIA/MES/ANO
                        if (textBox_BuscarAgendamento.Text == "" || textBox_BuscarData.Text == "")
                        {
                            MessageBox.Show("Insira Serviço e a Data para pesquisa");
                            return;
                        }
                        agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorServicoDiaMesAno(textBox_BuscarAgendamento.Text, textBox_BuscarData.Text);
                        break;
                    case 8: // BUSCAR AGENDAMENTO POR SERVICO ANO
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
                        agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorServicoAno(textBox_BuscarAgendamento.Text, dataconsulta);
                        break;
                    case 9: // BUSCAR AGENDAMENTO POR SERVICO E MÊS/ANO
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
                        agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorServicoMesAno(textBox_BuscarAgendamento.Text, dataconsulta);
                        break;
                    case 10: // Busca por nome do serviço
                        if (textBox_BuscarAgendamento.Text == "")
                        {
                            MessageBox.Show("Insira um Serviço, um mês e o Ano para pesquisa");
                            textBox_BuscarAgendamento.Focus();
                            return;

                        }
                        agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorServico(textBox_BuscarAgendamento.Text);
                        break;
                    case 11: // BUSCAR POR PROFISSIONAL E DIA/MÊS/ANO
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
                        opc = 1;
                        agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorProfissionalData(textBox_BuscarAgendamento.Text, dataconsulta, opc);
                        break;
                    case 12: // BUSCAR AGENDAMENTO POR PROFISSIONAL E MÊS/ANO
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
                        opc = 2; // USADO PARA SELECIONAR EM AGENDAMENTODAL A FORMA DE BUSCA
                        agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorProfissionalData(textBox_BuscarAgendamento.Text, dataconsulta, opc);
                        break;
                    case 13:// BUSCAR AGENDAMENTO POR PROFISSIONAL E ANO
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
                        opc = 3; // USADO PARA SELECIONAR EM AGENDAMENTODAL A FORMA DE BUSCA
                        agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorProfissionalData(textBox_BuscarAgendamento.Text, dataconsulta, opc);
                        break;

                    default:
                        MessageBox.Show("Escolha a forma de busca");
                        comboBox_SelecionarTipoBusca.Focus();
                        break;

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
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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