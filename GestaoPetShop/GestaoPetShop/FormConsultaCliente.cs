using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormConsultaCliente : Form
    {
        public Cliente Cliente { get; set; }

        public FormConsultaCliente()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 31 } } };

                        clienteBindingSource.DataSource = new ClienteBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        clienteBindingSource.DataSource = new ClienteBLL().BuscarPorNome(textBoxBuscar.Text);
                        break;
                    case 2:
                        clienteBindingSource.DataSource = new ClienteBLL().BuscarPorCPF(textBoxBuscar.Text);
                        break;
                    case 3:
                        clienteBindingSource.DataSource = new ClienteBLL().BuscarTodos();
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

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Cliente)clienteBindingSource.Current).Id;
                new ClienteBLL().Excluir(id);
                clienteBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                int opc = 0;
                using (FormCadastroCliente frm = new FormCadastroCliente(opc))
                {
                    frm.ShowDialog();
                }
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
                if (clienteBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe cliente para ser alterado.");
                    return;
                }

                int id = ((Cliente)clienteBindingSource.Current).Id;

                using (FormCadastroCliente frm = new FormCadastroCliente(id))
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

        private void FormConsultaCliente_Load(object sender, EventArgs e)
        {
        //TODO: This line of code loads data into the 'petshopDataSet.Cliente' table.You can move, or remove it, as needed.
        //    this.clienteTableAdapter.Fill(this.petshopDataSet.Cliente);
        //    comboBoxBuscarPor.SelectedIndex = 3;
        }

        private void buttonVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe cliente para ser alterado.");
                    return;
                }

                int id = ((Cliente)clienteBindingSource.Current).Id;

                using (FormCadastroCliente frm = new FormCadastroCliente(id, false))
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

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteBindingSource.Count == 0)
                    throw new Exception("Selecione um Cliente!");

                this.Cliente = (Cliente)clienteBindingSource.Current;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
