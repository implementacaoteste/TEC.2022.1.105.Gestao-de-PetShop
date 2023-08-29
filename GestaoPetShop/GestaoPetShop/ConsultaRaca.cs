using BLL;
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
    public partial class ConsultaRaca : Form
    {
        int id;
        public ConsultaRaca()
        {
            InitializeComponent();
            id = id;
        }

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
    }
}
