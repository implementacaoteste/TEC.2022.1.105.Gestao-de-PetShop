using BLL;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormConsultaCliente : Form
    {
        public Cliente Cliente { get; set; }
        int selecionarcliente;
        public FormConsultaCliente(int _selecionarcliente = 0)
        {
            InitializeComponent();
            selecionarcliente = _selecionarcliente;
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

                if (MessageBox.Show("Os animais vinculados a este Clientes serão excluídos. \n Deseja realmente continuar?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                Cliente cliente = new Cliente();

                cliente = (Cliente)clienteBindingSource.Current;
                new ClienteBLL().Excluir(cliente);
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
                //int opc = 0; 
                //using (FormCadastroCliente frm = new FormCadastroCliente(opc))
                using (FormCadastroCliente frm = new FormCadastroCliente())
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
        private void FormConsultaCliente_Load(object sender, EventArgs e)
        {
            LoadTheme();
            //TODO: This line of code loads data into the 'petshopDataSet.Cliente' table.You can move, or remove it, as needed.
            //    this.clienteTableAdapter.Fill(this.petshopDataSet.Cliente);
            comboBoxBuscarPor.SelectedIndex = 3;
            textBoxBuscar.Enabled = false;
            if (selecionarcliente == 1)
            {
                buttonSelecionar.Visible = true;
                buttonExcluir.Enabled = false;
                buttonInserir.Enabled = false;
                buttonAlterar.Enabled = false;

            }
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void comboBoxBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBuscarPor.SelectedIndex != 3)
                textBoxBuscar.Enabled = true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            Close();
        }
    }

}
