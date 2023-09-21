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
    public partial class FormConsultaUsuario : Form
    {
        public FormConsultaUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxSelecionarTipoPesquisaUsuario.SelectedIndex)
                {
                    case 0:
                        {
                            usuarioBindingSource.DataSource = new UsuarioBLL().BuscarTodos();
                            break;
                        }
                        case 1:
                        {
                            usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorLogin(textBoxBuscarUsuario.Text) ;
                            break;
                        }
                    case 2:
                        {
                            usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorNomeProfissional(textBoxBuscarUsuario.Text);
                            break;
                        }
                    case 3:
                        {
                            usuarioBindingSource.DataSource = new UsuarioBLL().BucarPorIdProfissional(Convert.ToInt32(textBoxBuscarUsuario.Text));
                            break;
                        }
                     
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInserirUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                using(FormCadastroUsuario frm = new FormCadastroUsuario())
                {
                    frm.ShowDialog(); 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if(usuarioBindingSource.Count < 1)
                {

                    MessageBox.Show("Selecione um Usuário.");
                    return;
                }
                int id = ((Usuario)usuarioBindingSource.Current).Id;

                using (FormCadastroUsuario frm = new FormCadastroUsuario(id))
                {
                    frm.ShowDialog();
                }
                switch (comboBoxSelecionarTipoPesquisaUsuario.SelectedIndex)
                {
                    case 0:
                        {
                            usuarioBindingSource.DataSource = new UsuarioBLL().BuscarTodos();
                            break;
                        }
                    case 1:
                        {
                            usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorLogin(textBoxBuscarUsuario.Text);
                            break;
                        }
                    case 2:
                        {
                            usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorNomeProfissional(textBoxBuscarUsuario.Text);
                            break;
                        }
                    case 3:
                        {
                            usuarioBindingSource.DataSource = new UsuarioBLL().BucarPorIdProfissional(Convert.ToInt32(textBoxBuscarUsuario.Text));
                            break;
                        }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuarioBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Usuario)usuarioBindingSource.Current).Id;
                new UsuarioBLL().Excluir(id);
                usuarioBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
