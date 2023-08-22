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
        public FormCadastroCliente(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
               

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
            try
            {
                if (id == 0)
                    clienteBindingSource.AddNew();
                else
                    clienteBindingSource.DataSource = new ClienteBLL().BuscarPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
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
            emailClienteBindingSource.AddNew();
            ((EmailCliente)emailClienteBindingSource.Current).Email = textBoxEmail.Text;

            emailClienteBindingSource.EndEdit();
        }

        private void buttonInserirTelefone_Click(object sender, EventArgs e)
        {
           telefoneClientesBindingSource.AddNew();
            ((TelefoneCliente)telefoneClientesBindingSource.Current).Telefone = textBoxTelefone.Text;

            telefoneClientesBindingSource.EndEdit();
        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
