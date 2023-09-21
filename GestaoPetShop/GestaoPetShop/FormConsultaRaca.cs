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
    public partial class FormConsultaRaca : Form
    {


        int id;
        public FormConsultaRaca()
        {
            InitializeComponent();
            id = id;
        }
        public Raca Raca { get; set; }

        private void racaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.racaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void ConsultaPorRaca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petshopDataSet.Raca' table. You can move, or remove it, as needed.
            // this.racaTableAdapter.Fill(this.petshopDataSet.Raca);
            comboBox1.SelectedIndex = 0;

            try
            {
                if (id == 0)
                    racaBindingSource.AddNew();
                else
                    racaBindingSource.DataSource = new AnimalBLL().BuscarPorId(id);
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
                using (FormCadastroRaca frm = new FormCadastroRaca())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        racaBindingSource.DataSource = new RacaBLL().BuscarTodos();
                        break;
                    case 1:
                        racaBindingSource.DataSource = new RacaBLL().BuscarPorNome(textBoxBuscar.Text);
                        break;
                    case 2:
                        racaBindingSource.DataSource = new RacaBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
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

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (racaBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe raça para ser alterado.");
                    return;
                }

                int id = ((Raca) racaBindingSource.Current).Id;

                using (FormCadastroRaca frm = new FormCadastroRaca(id))
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (racaBindingSource.Count  == 0)
                    throw new Exception("Selecione uma Raça!");

                this.Raca = (Raca)racaBindingSource.Current;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelBuscraPorAnimal_Click(object sender, EventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (racaBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Raca)racaBindingSource.Current).Id;
                new RacaBLL().Excluir(id);
                racaBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
