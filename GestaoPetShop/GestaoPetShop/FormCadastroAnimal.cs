using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace GestaoPetShop
{
    public partial class FormCadastroAnimal : Form
    {


        int id;
        //bool permitirSalvar;
        public FormCadastroAnimal(int _id = 0)
        {
            InitializeComponent();
            this.id = _id;
            //buttonSalvar.Visible = _permitirSalvar;
            //permitirSalvar = _permitirSalvar;
            //, bool _permitirSalvar = true
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!permitirSalvar)
                //    return;


                animalBindingSource.EndEdit();
                Animal animal = (Animal)animalBindingSource.Current;


                if (id == 0)
                    new AnimalBLL().Inserir(animal);
                else
                    new AnimalBLL().Alterar(animal);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastroAnimal_Load(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                LoadTheme();
                
                if (id == 0)
                {
                    labelCadastrarAnimal.Visible = true;
                    labelAlterarAnimal.Visible = false;
                    animalBindingSource.AddNew();
                    textBox5.Text = "";
                }
                else
                {
                    labelCadastrarAnimal.Visible = false;
                    labelAlterarAnimal.Visible = true;
                    animalBindingSource.AddNew();
                    animalBindingSource.DataSource = new AnimalBLL().BuscarPorId(id);
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
        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int selecionarcliente = 1;
                using (FormConsultaCliente frm = new FormConsultaCliente(selecionarcliente))
                {
                    frm.ShowDialog();

                    if (frm.Cliente != null)
                    {
                        ((Animal)animalBindingSource.Current).IdCliente = frm.Cliente.Id;
                        ((Animal)animalBindingSource.Current).Cliente = frm.Cliente;
                        textBox8.Text = frm.Cliente.Nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuscarRaca_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaRaca frm = new FormConsultaRaca())
                {
                    frm.ShowDialog();

                    if (frm.Raca != null)
                    {
                        ((Animal)animalBindingSource.Current).IdRaca = frm.Raca.Id;
                        ((Animal)animalBindingSource.Current).Raca = frm.Raca;
                        textBox9.Text = frm.Raca.Nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            textBox8.Focus();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.SelectionStart = 0;
        }
    }
}
