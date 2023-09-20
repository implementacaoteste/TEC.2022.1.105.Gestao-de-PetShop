using BLL;
using Models;
using System;
using System.Collections.Generic;
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

            //  agendamentoDataGridView.DataSource = new Agendamento();// ERA APENAS UM TESTE -DEIXEI AQUI SÓ PRA LEMBRAR


            try
            {
                using (FormLogin frm = new FormLogin())
                {
                    frm.ShowDialog();
                    if (!frm.Logou)
                        Application.Exit();
                    lblUsuarioLogado.Text = Constantes.UsuarioLogado;
                }
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
                int opcativo = 0;
                int opcsituacao = 0;
                agendamentoBindingSource.DataSource = new AgendamentoBLL().BuscarAgendamentoPorData(opcbusca, dataconsultaagendamento, opcativo, opcsituacao);

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
    }
}
