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
    public partial class ConsultaAgendamento : Form
    {
        public ConsultaAgendamento()
        {
            InitializeComponent();
        }

        private void button_BuscarAgendamentos_Click(object sender, EventArgs e)
        {
            try
            {
                AgendamentoBLL agendamentoBLL = new AgendamentoBLL();

                if (comboBox_SelecionarTipoBusca.SelectedIndex == 0)
                {

                    dataGridView1_FormsPrincipalBindingSource.DataSource = agendamentoBLL.BuscarTodos();
                }

                else if (comboBox_SelecionarTipoBusca.SelectedIndex == 1)
                {


                    dataGridView1_FormsPrincipalBindingSource.DataSource = agendamentoBLL.BuscarPorId(Convert.ToInt32(textBox_BuscarAgendamento.Text));

                }
                else if (comboBox_SelecionarTipoBusca.SelectedIndex == 2)
                {


                    dataGridView1_FormsPrincipalBindingSource.DataSource = agendamentoBLL.BuscarPorNomeAnimal(textBox_BuscarAgendamento.Text);

                }
                else
                {
                    MessageBox.Show("Escolha a forma de busca");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
