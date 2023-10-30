using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormCadastroCliente : Form
    {
        int id;
        bool permitirSalvar;
        public FormCadastroCliente(int _id = 0, bool _permitirSalvar = true)
        {
            InitializeComponent();
            id = _id;
            buttonSalvar.Visible = _permitirSalvar;
            permitirSalvar = _permitirSalvar;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!permitirSalvar)
                    return;

                //List<EmailCliente> emailClientes = new List<EmailCliente>();
                //EmailCliente emailCliente = new EmailCliente();
                //List<TelefoneCliente> telefoneClientes = new List<TelefoneCliente>();
                //TelefoneCliente telefoneCliente = new TelefoneCliente();
                //int quantidadeemail = emailClienteBindingSource.Count;
                //int quantidadetelefone = telefoneClientesBindingSource.Count;

                //for (int x = 0; x < quantidadeemail; x++)
                //{
                //    emailCliente.Email = ((EmailCliente)emailClienteBindingSource.Current).Email;


                //    emailClientes.Add(emailCliente);

                //}
                //cliente.EmailCliente = emailClientes;

                //for (int x = 0; x < quantidadetelefone; x++)
                //{
                //    telefoneCliente.Telefone = ((TelefoneCliente)telefoneClientesBindingSource.Current).Telefone;


                //    telefoneClientes.Add(telefoneCliente);

                //}
                //cliente.TelefoneClientes = telefoneClientes;

                clienteBindingSource.EndEdit();
                Cliente cliente = (Cliente)clienteBindingSource.Current;
                //cliente.EmailCliente = (List<EmailCliente>)emailClienteBindingSource.DataSource;

                if (id == 0)
                    new ClienteBLL().Inserir(cliente);
                else
                    new ClienteBLL().Alterar(cliente);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                LoadTheme();

                if (id == 0)
                {
                    label1CadastrarCliente.Visible = true;
                    label2AlterarCliente.Visible = false;
                    clienteBindingSource.AddNew();
                }
                else
                {
                    label1CadastrarCliente.Visible = false;
                    label2AlterarCliente.Visible = true;
                    clienteBindingSource.AddNew();
                    clienteBindingSource.DataSource = new ClienteBLL().BuscarPorId(id);
                }

                if (!permitirSalvar)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (!item.Name.Contains("DataGridView"))
                            item.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoDaImagem = openFileDialog.FileName;
                pictureBoxFoto.Image = Image.FromFile(caminhoDaImagem);
            }
        }

        private void buttonInserirEmail_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                MessageBox.Show("O campo de E-mail não foi preenchido");
                return;
            }
            emailClienteBindingSource.AddNew();
            ((EmailCliente)emailClienteBindingSource.Current).Email = textBoxEmail.Text;

            emailClienteBindingSource.EndEdit();
            textBoxEmail.Text = "";
        }

        private void buttonInserirTelefone_Click(object sender, EventArgs e)
        {
            if (textBoxTelefone.Text == "")
            {
                MessageBox.Show("O campo de Telefone não foi preenchido");
                return;
            }
            telefoneClientesBindingSource.AddNew();
            ((TelefoneCliente)telefoneClientesBindingSource.Current).Telefone = textBoxTelefone.Text;

            telefoneClientesBindingSource.EndEdit();
            textBoxTelefone.Text = "";
        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtivocheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void emailClienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonExcluirEmail_Click(object sender, EventArgs e)
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

                int id = ((EmailCliente)emailClienteBindingSource.Current).Id;
                new EmailClienteBLL().Excluir(id);
                emailClienteBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirTelefone_Click(object sender, EventArgs e)
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

                int id = ((TelefoneCliente)telefoneClientesBindingSource.Current).Id;
                new TelefoneClienteBLL().Excluir(id);
                telefoneClientesBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rGTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nomeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            nomeTextBox.Focus();
        }

        private void rGTextBox_Click(object sender, EventArgs e)
        {
            rGTextBox.SelectionStart = 0;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.SelectionStart = 0;
        }

        private void cPFTextBox_Click(object sender, EventArgs e)
        {
            cPFTextBox.SelectionStart = 0;
        }

        private void textBoxTelefone_Click(object sender, EventArgs e)
        {
            textBoxTelefone.SelectionStart = 0;
        }
    }
}
