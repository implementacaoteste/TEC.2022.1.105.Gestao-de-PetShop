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
    public partial class frmCadastroAgendamento : Form
    {
        public frmCadastroAgendamento()
        {
            InitializeComponent();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            animalBindingSource.AddNew();
            groupBox1.Enabled = true;
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            animalBindingSource.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            animalBindingSource.MovePrevious();
        }

        private void btnPosterior_Click(object sender, EventArgs e)
        {
            animalBindingSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            animalBindingSource.MoveLast();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirme exclusão do registro", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    animalBindingSource.RemoveCurrent();
                    animalTableAdapter.Update(petshopDataSet.Animal);
                }
            }
            catch (Exception)
            {
                animalTableAdapter.Fill(petshopDataSet.Animal);
                MessageBox.Show("Registro não pode ser excluído");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            animalBindingSource.CancelEdit();
            groupBox1.Enabled= false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.animalBindingSource.EndEdit();
                animalTableAdapter.Update(petshopDataSet.Animal);
                groupBox1.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");
            }
        }
    }
}
