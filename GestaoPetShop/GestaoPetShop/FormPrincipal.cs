using System;
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
    }
}
