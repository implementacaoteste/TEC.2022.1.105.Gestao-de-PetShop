using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaUsuario frm = new FormConsultaUsuario())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {

                string dataconsultaagendamento =Convert.ToString(DateTime.Now);

                //textBoxQuantidadeAgendado.Text = Convert.ToString(new AgendamentoBLL().BuscarAgendamentoPorData(4, dataconsultaagendamento, 1, 1).Count);
                //textBox2QuantidadeEmAndamento.Text = Convert.ToString(new AgendamentoBLL().BuscarAgendamentoPorData(4, dataconsultaagendamento, 1, 2).Count);
                //textBoxQuantidadeFinalizado.Text = Convert.ToString(new AgendamentoBLL().BuscarAgendamentoPorData(4, dataconsultaagendamento, 1, 3).Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaCliente frm = new FormConsultaCliente())
            {
                frm.ShowDialog();
            }
        }

        private void servicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaServico frm = new FormConsultaServico())
            {
                frm.ShowDialog();
            }

        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaAgendamento frm = new FormConsultaAgendamento())
            {
                frm.ShowDialog();
            }
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaAnimal frm = new FormConsultaAnimal())
            {
                frm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string dataconsultaagendamento = monthCalendar1.SelectionStart.ToShortDateString();
                int opcbusca = 4;
                int opcativo = 1;
                int opcsituacao = 0;
                List<Agendamento> agendamento = new AgendamentoBLL().BuscarAgendamentoPorData(opcbusca, dataconsultaagendamento, opcativo, opcsituacao);
                agendamentoBindingSource.DataSource = agendamento;
                //int quantAgendado=0;
                //int quantEmAndamento=0;
                //int quantFinalizado=0;
                //foreach (var item in agendamento)
                //{
                //    if (item.IdSituacao == 1)
                //    {
                //        quantAgendado++;
                //    }
                //    if (item.IdSituacao == 2)
                //    {
                //        quantEmAndamento++;
                //    }
                //    if (item.IdSituacao == 3)
                //    {
                //        quantFinalizado++;
                //    }
                //}

                //textBoxQuantidadeAgendado.Text = Convert.ToString(quantAgendado);
                //textBox2QuantidadeEmAndamento.Text = Convert.ToString(quantEmAndamento);
                //textBoxQuantidadeFinalizado.Text = Convert.ToString(quantFinalizado);

                agendamentoDataGridView.Visible = true;
                agendamentoServicosDataGridView.Visible = true;
                button2.Visible = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agendamentoDataGridView.Visible = false;
            agendamentoServicosDataGridView.Visible = false;
            button2.Visible = false;

        }

        private void raçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaRaca frm = new FormConsultaRaca())
            {
                frm.ShowDialog();
            }
        }

        private void profissionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaProfissional frm = new FormConsultaProfissional())
            {
                frm.ShowDialog();
            }
        }

        private void funçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaFuncao frm = new FormConsultaFuncao())
                {
                    frm.ShowDialog();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Relatorio.FormRelatorioCliente frm = new Relatorio.FormRelatorioCliente();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBoxSituacao_Enter(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                string dataconsultaagendamento = Convert.ToString(DateTime.Now);
                int opcbusca = 4;
                int opcativo = 1;
                int opcsituacao = 0;
                List<Agendamento> agendamento = new AgendamentoBLL().BuscarAgendamentoPorData(opcbusca, dataconsultaagendamento, opcativo, opcsituacao);
              
                int quantAgendado = 0;
                int quantEmAndamento = 0;
                int quantFinalizado = 0;
                foreach (var item in agendamento)
                {
                    if (item.IdSituacao == 1)
                    {
                        quantAgendado++;
                    }
                    if (item.IdSituacao == 2)
                    {
                        quantEmAndamento++;
                    }
                    if (item.IdSituacao == 3)
                    {
                        quantFinalizado++;
                    }
                }

                textBoxQuantidadeAgendado.Text = Convert.ToString(quantAgendado);
                textBox2QuantidadeEmAndamento.Text = Convert.ToString(quantEmAndamento);
                textBoxQuantidadeFinalizado.Text = Convert.ToString(quantFinalizado);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
