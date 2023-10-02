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
        bool permitirSalvar;
        public FormCadastroAnimal(int _id = 0)
        {
            InitializeComponent();
            id = _id;
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


                Animal animal = (Animal)animalBindingSource.Current;
                animalBindingSource.EndEdit();


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
            try
            {
                LoadTheme();

                if (id == 0)
                {
                    animalBindingSource.AddNew();
                    textBox5.Text = "";

                }
                else
                {

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
                using (FormConsultaCliente frm = new FormConsultaCliente())
                {
                    frm.ShowDialog();

                    if (frm.Cliente != null)
                    {
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

    }
}
