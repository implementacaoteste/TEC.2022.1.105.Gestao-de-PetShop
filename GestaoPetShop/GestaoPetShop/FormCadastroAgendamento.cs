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
    public partial class FormCadastroAgendamento : Form
    {
        public FormCadastroAgendamento()
        {
            InitializeComponent();
        }

       

       

        private void FormCadastroAgendamento_Load(object sender, EventArgs e)
        {
            try
            {

                List<DataGridView_Servico> listViewServico = new List<DataGridView_Servico>();

                listViewServico = new AgendamentoBLL().BuscarsServicoPorNome(servicoComboBox.Text);
                    

                    int num = listViewServico.Count();
                MessageBox.Show(Convert.ToString(num));
                    for (int x = 0; x <= num; x++)
                    {
                        servicoComboBox.Items.Insert(x, listViewServico[x].Servico);
                    }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void servicoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int quant = 0;
            quantidadeTextBox.Text = "0";
            DataGridView_Servico viewServico = new DataGridView_Servico();
            viewServico = new AgendamentoBLL().PorNome(servicoComboBox.SelectedText);
            idTextBox.Text = Convert.ToString(viewServico.Id);
            servicoComboBox.Text = viewServico.Servico;
            valorUnitarioTextBox.Text = Convert.ToString(viewServico.ValorUnitario);
            valorComDescontoTextBox.Text = valorUnitarioTextBox.Text;
             quant = Convert.ToInt32(quantidadeTextBox.Text);
            decimal valorUni = Convert.ToDecimal(valorComDescontoTextBox.Text);
            decimal valorT = quant * valorUni;
            valorTotalTextBox.Text = Convert.ToString(valorT);
        }

        private void quantidadeTextBox_TextChanged(object sender, EventArgs e)
        {
            int quant = Convert.ToInt32(quantidadeTextBox.Text);
            decimal valorUni = Convert.ToDecimal(valorComDescontoTextBox.Text);
            decimal valorT = quant * valorUni;
            valorTotalTextBox.Text = Convert.ToString(valorT);
        }
    }
}
