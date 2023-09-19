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
    public partial class FormConsultaProfissional : Form
    {
        private int opc;
        public int id;
        public string nome;
        public FormConsultaProfissional(int _opc = 0)
        {
            InitializeComponent();
            opc = _opc;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", -1 } } };

                        profissionalBindingSource.DataSource = new ProfissionalBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        profissionalBindingSource.DataSource = new ProfissionalBLL().BuscarPorNome(textBoxBuscar.Text);
                        break;
                    case 2:
                        profissionalBindingSource.DataSource = new ProfissionalBLL().BuscarPorCPF(textBoxBuscar.Text);
                        break;
                    case 3:
                        profissionalBindingSource.DataSource = new ProfissionalBLL().BuscarTodos();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (profissionalBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }
                if (MessageBox.Show("Deseja realmente excluir este registro ?", "Atenção !", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Profissional)profissionalBindingSource.Current).Id;
                new ProfissionalBLL().Excluir(id);
                profissionalBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                
                //int id = ((Profissional)profissionalBindingSource.Current).Id;
                using (FormCadastroProfissional frm = new FormCadastroProfissional())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (profissionalBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe profissional para ser alterado.");
                    return;
                }
                int id = ((Profissional)profissionalBindingSource.Current).Id;

                using (FormCadastroProfissional frm = new FormCadastroProfissional(id))
                {
                    frm.ShowDialog();
                }
                btnBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (profissionalBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe Profissional para ser alterado.");
                    return;
                }
                int id = ((Profissional)profissionalBindingSource.Current).Id;
                using (FormCadastroProfissional frm = new FormCadastroProfissional(id))
                {
                    frm.ShowDialog();
                }
                btnBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConsultaProfissional_Load(object sender, EventArgs e)
        {
            try
            {
                if (opc == 1)
                {
                    btnInserir.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnSelecionar.Enabled = true;
                    btnSelecionar.Visible = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (profissionalBindingSource.Count > 0)
                {
                    id = ((Profissional)profissionalBindingSource.Current).Id;
                    nome = ((Profissional)profissionalBindingSource.Current).Nome;
                    Close();
                }
                else
                {
                    MessageBox.Show("Não foi selecionado um Profissional");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
