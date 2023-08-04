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
    public partial class FormCadastroAgendamento : Form
    {
        public FormCadastroAgendamento()
        {
            InitializeComponent();
        }

        private void agendamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void FormCadastroAgendamento_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'petshopDataSet.Situacao' table. You can move, or remove it, as needed.
            //this.situacaoTableAdapter.Fill(this.petshopDataSet.Situacao);
            //// TODO: This line of code loads data into the 'petshopDataSet.Profissional' table. You can move, or remove it, as needed.
            //this.profissionalTableAdapter.Fill(this.petshopDataSet.Profissional);
            //// TODO: This line of code loads data into the 'petshopDataSet.Animal' table. You can move, or remove it, as needed.
            //this.animalTableAdapter.Fill(this.petshopDataSet.Animal);
            //// TODO: This line of code loads data into the 'petshopDataSet.Agendamento' table. You can move, or remove it, as needed.
            //this.agendamentoTableAdapter.Fill(this.petshopDataSet.Agendamento);

        }

        
    }
}
