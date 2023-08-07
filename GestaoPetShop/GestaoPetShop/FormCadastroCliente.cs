using BLL;
using Models;
using System;
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
                Cliente cliente = (Cliente)clienteBindingSource.Current;

                //if (pictureBoxFoto.Image != null)
                //    using (MemoryStream ms = new MemoryStream())
                //    {
                //        pictureBoxFoto.Image.Save(ms, pictureBoxFoto.Image.RawFormat);
                //        cliente.Foto = ms.ToArray();
                //    }

                clienteBindingSource.EndEdit();

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
    }
}
