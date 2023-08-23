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
    public partial class FormCadastroAnimal : Form
    {
        int id;
        public FormCadastroAnimal(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {

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
            animalBindingSource.CancelEdit();
        }

        private void FormCadastroAnimal_Load(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                    animalBindingSource.AddNew();
                else
                    animalBindingSource.DataSource = new AnimalBLL().BuscarPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
