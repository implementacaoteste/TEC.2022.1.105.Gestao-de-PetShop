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

    public partial class FormConsultaAnimal : Form
    {
      
        public FormConsultaAnimal()
        {
            InitializeComponent();
           
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        animalBindingSource.DataSource = new AnimalBLL().BuscarTodos();
                        break;
                    case 1:
                        animalBindingSource.DataSource = new AnimalBLL().BuscarPorNome(textBoxBuscar.Text);
                        break;
                    case 2:
                        animalBindingSource.DataSource = new AnimalBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 21 } } };
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
        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void FormConsultaAnimal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.Animal' table. You can move, or remove it, as needed.
            // this.animalTableAdapter.Fill(this.petshopDataSet.Animal);

             comboBox1.SelectedIndex = 0;


        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (animalBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Animal)animalBindingSource.Current).Id;
                new AnimalBLL().Excluir(id);
                animalBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonIserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroAnimal frm = new FormCadastroAnimal())
                {
                    frm.ShowDialog();
                }
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

       
    }
}
