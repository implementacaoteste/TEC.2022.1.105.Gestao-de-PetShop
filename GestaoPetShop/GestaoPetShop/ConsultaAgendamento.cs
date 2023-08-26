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
                if (comboBox_SelecionarTipoBusca.SelectedIndex == 0) // BUSCAR TODOS OS AGENDAMENTOS
                {
                    agendamentoBindingSource.DataSource = agendamentoBLL.BuscarTodos();
                }
                else if (comboBox_SelecionarTipoBusca.SelectedIndex == 1) // BUSCAR AGENDAMENTO POR ID
                {
                    if (textBox_BuscarAgendamento.Text == "")
                    {
                        MessageBox.Show("Insirar um Id(código) do Agendamento para pesquisa");
                        return;
                    }
                    int opc = 0;
                    agendamentoBindingSource.DataSource = agendamentoBLL.BuscarAgendamentoPorId(Convert.ToInt32(textBox_BuscarAgendamento.Text), opc);
                }
                else if (comboBox_SelecionarTipoBusca.SelectedIndex == 2)
                {
                    if (textBox_BuscarAgendamento.Text == "")
                    {
                        MessageBox.Show("Insirar o Nome do Animal para pesquisa");
                        return;
                    }
                }
                else if (comboBox_SelecionarTipoBusca.SelectedIndex == 3)
                {
                    if (textBox_BuscarAgendamento.Text == "")
                    {
                        MessageBox.Show("Insirar o Nome do Cliente para pesquisa");
                        return;
                    }
                    agendamentoBindingSource.DataSource = agendamentoBLL.BuscarPorNomeCliente(textBox_BuscarAgendamento.Text);
                }
                else if (comboBox_SelecionarTipoBusca.SelectedIndex == 4) // BUSCAR POR DIA/MÊS/ANO
                {
                    string quant = textBox_BuscarData.Text;
                    if (textBox_BuscarData.Text == "")
                    {
                        MessageBox.Show("Insirar o Data para pesquisa");
                        return;
                    }
                    agendamentoBindingSource.DataSource = agendamentoBLL.BuscarPorDiaMesAno(textBox_BuscarData.Text);
                }
                else if (comboBox_SelecionarTipoBusca.SelectedIndex == 5) // BUSCAR POR MÊS E ANO
                {
                    if (textBox_BuscarData.Text == "")
                    {
                        MessageBox.Show("Insirar o Data para pesquisa");
                        return;
                    }
                    int opc = 5;
                    string dataconsulta = textBox_BuscarData.Text;
                    if (dataconsulta.Count() == 7)
                    {
                        dataconsulta = "01/" + textBox_BuscarData.Text; // COMPLETAR O NUMERO DA DATA PARA A PESQUISA EM BD
                    }
                    else
                    {
                        dataconsulta = textBox_BuscarData.Text;
                    }
                    agendamentoBindingSource.DataSource = agendamentoBLL.BuscarPorMesAno(opc, dataconsulta);
                }
                else if (comboBox_SelecionarTipoBusca.SelectedIndex == 6) // BUSCAR POR ANO
                {
                    if (textBox_BuscarData.Text == "")
                    {
                        MessageBox.Show("Insirar o Data para pesquisa");
                        return;
                    }
                    int opc = 6;
                    string dataconsulta = textBox_BuscarData.Text;
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
                }
                else if (comboBox_SelecionarTipoBusca.SelectedIndex == 7) // BUSCAR AGENDAMENTO POR PROFISSINAIS
                {
                    if (textBox_BuscarAgendamento.Text == "")
                    {
                        MessageBox.Show("Insirar o Profissional para pesquisa");
                        return;
                    }
                    agendamentoBindingSource.DataSource = agendamentoBLL.BuscarPorProfissional(textBox_BuscarAgendamento.Text);
                }
                else
                {
                    MessageBox.Show("Escolha a forma de busca");
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