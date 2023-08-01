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
        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
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
            //dataGridView1_Agendamentos.DataSource = new DataGridView1_FormsPrincipal(); ERA APENAS UM TESTE - DEIXEI AQUI SÓ PRA LEMBRAR
           
            try
            {
                using (FormLogin frm = new FormLogin())
                {
                    frm.ShowDialog();
                    if (!frm.Logou)
                        Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void gruposDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
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
            using (FormConsultaCliente frm  = new FormConsultaCliente())
            {
                frm.ShowDialog();
            }
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaServico frm = new FormConsultaServico())
            {
                frm.ShowDialog();
            }

        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCadastroAgendamento frm = new FormCadastroAgendamento())
            {
                frm.ShowDialog();
            }
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCadastroAnimal frm = new FormCadastroAnimal())
            {
                frm.ShowDialog();
                //frm.TopLevel = false;
                //frm.Dock = DockStyle.Fill;
            }
        }
        /* ERA APENAS UM TESTE - DEIXEI AQUI SÓ PRA LEMBRAR
//private void button_BuscarAgendamento_Click(object sender, EventArgs e)
//{
//    string dataag = monthCalendar1.SelectionStart.ToShortDateString();

//    dataGridView1_Agendamentos.DataSource = new ServicoBLL().dataGridView(dataag);



//    dataGridView1_Agendamentos.Visible = true;
//    button1_FecharViewAgendamento.Visible = true;
//}

//private void button1_FecharViewAgendamento_Click(object sender, EventArgs e)
//{
//    dataGridView1_Agendamentos.Visible = false;
//    button1_FecharViewAgendamento.Visible = false;
//}
*/
    }
}
