using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormConsultaGrupoUsuario : Form
    {
        public int Id;
        private string ultimaBusca;
        private bool buscou;
        public FormConsultaGrupoUsuario()
        {
            InitializeComponent();
            ultimaBusca = "";
            buscou = false;
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                grupoUsuarioBindingSource.DataSource = new GrupoUsuarioBLL().BuscarPorNomeGrupo(textBoxBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grupoUsuarioBindingSource.Count > 0)
                {
                    Id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
                    Close();
                }
                else
                    MessageBox.Show("Não existe registro para ser selecionado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConsultaGrupoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.Down)
            {
                grupoUsuarioBindingSource.MoveNext();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                grupoUsuarioBindingSource.MovePrevious();
                e.Handled = true;
            }
        }

        private void grupoUsuarioDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            buttonSelecionar_Click(null, null);
        }

        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!buscou || ultimaBusca != textBoxBuscar.Text)
                {
                    buttonBuscar_Click(null, null);
                    ultimaBusca = textBoxBuscar.Text;
                    buscou = true;
                }
                else
                    buttonSelecionar_Click(null, null);
            }
        }
    }
}
