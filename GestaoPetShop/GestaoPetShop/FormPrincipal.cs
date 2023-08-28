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
                using (FormBuscarUsuario frm = new FormBuscarUsuario())
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

        private void gruposDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarGrupoUsuario frm = new FormBuscarGrupoUsuario())
                {
                    frm.ShowDialog();
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
            using (ConsultaAgendamento frm = new ConsultaAgendamento())
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
            string dataag = monthCalendar1.SelectionStart.ToShortDateString();

            agendamentoBindingSource.DataSource = new AgendamentoBLL().BuscarPorDiaMesAno(dataag);

            agendamentoDataGridView.Visible = true;
            agendamentoServicosDataGridView.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agendamentoDataGridView.Visible = false;
            agendamentoServicosDataGridView.Visible = false;
            button2.Visible = false;
            
        }
    }
}
