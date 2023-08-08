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
        decimal precoAplicado;
        decimal subtotal;
        int quatidade;
        public FormCadastroAgendamento()
        {
            InitializeComponent();
        }

       

       

        private void FormCadastroAgendamento_Load(object sender, EventArgs e)
        {
            try
            {

                List<DataGridView_Servico> listViewServico = new List<DataGridView_Servico>();

                listViewServico = new AgendamentoBLL().BuscarsServicoPorNome(descricaoComboBox.Text);


                int num = listViewServico.Count();
                MessageBox.Show(Convert.ToString(num));
                    for (int x = 0; x <= num; x++)
                    {
                    descricaoComboBox.Items.Insert(x, listViewServico[x].Servico);
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

       

        private void descricaoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataGridView_Servico viewServico = new DataGridView_Servico();

            servicoBindingSource.DataSource = new AgendamentoBLL().PorNome(descricaoComboBox.SelectedText);
            textBox_PrecoAplicado.Text = precoTextBox.Text;
        }

        private void textBox_Subtotal_TextChanged(object sender, EventArgs e)
        {
           
            precoAplicado = Convert.ToDecimal(textBox_PrecoAplicado.Text);

            subtotal = quatidade * precoAplicado;
            textBox_Subtotal.Text = Convert.ToString(subtotal);
        }
    }
}
