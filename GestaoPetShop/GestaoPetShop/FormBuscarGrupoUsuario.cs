using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormBuscarGrupoUsuario : Form
    {
        public FormBuscarGrupoUsuario()
        {
            InitializeComponent();
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

        private void buttonAdicionarGrupoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroGrupoUsuario frm = new FormCadastroGrupoUsuario())
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if(grupoUsuarioBindingSource.Count == 0)
                    throw new Exception("Não existe grupo listado para ser alterado.");

                using (FormCadastroGrupoUsuario frm = new FormCadastroGrupoUsuario(((GrupoUsuario)grupoUsuarioBindingSource.Current).Id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirGrupoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (grupoUsuarioBindingSource.Count == 0)
                    throw new Exception("Não existe grupo a ser excluído");
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                new GrupoUsuarioBLL().Excluir(((GrupoUsuario)grupoUsuarioBindingSource.Current).Id);
                grupoUsuarioBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                if (grupoUsuarioBindingSource.Count == 0)
                    throw new Exception("Não existe um grupo selecionado para adicionar uma permissão.");

                using (FormConsultaPermissao frm = new FormConsultaPermissao())
                {
                    frm.ShowDialog();
                    int idGrupo = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
                    new GrupoUsuarioBLL().AdicionarPermissao(idGrupo, frm.Id);
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                if (permissoesBindingSource.Count == 0)
                    throw new Exception("Não existe permissão a ser excluída.");

                int idGrupo = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
                int idPermissao = ((Permissao)permissoesBindingSource.Current).Id;
                new GrupoUsuarioBLL().RemoverPermissao(idGrupo, idPermissao);
                permissoesBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormBuscarGrupoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();

            else if (e.KeyCode == Keys.Down)
            {
                if (e.Control)
                    permissoesBindingSource.MoveNext();
                else
                    grupoUsuarioBindingSource.MoveNext();

                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (e.Control)
                    permissoesBindingSource.MovePrevious();
                else
                    grupoUsuarioBindingSource.MovePrevious();
                e.Handled = true;
            }
        }
        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonBuscar_Click(null, null);
        }
    }
}
