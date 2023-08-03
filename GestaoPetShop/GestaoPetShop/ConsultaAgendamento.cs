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

                //if (comboBox_SelecionarTipoBusca.SelectedIndex == 0)
                //{

                //    servicoBindingSource.DataSource = servicoBLL.BuscarTodos();
                //}

                //else if (comboBox_SelecionarTipoBusca.SelectedIndex == 1)
                //{


                //    servicoBindingSource.DataSource = servicoBLL.BuscarPorId(Convert.ToInt32(textBox_BuscarServico.Text));

                //}
                //else if (comboBox_SelecionarTipoBusca.SelectedIndex == 2)
                //{


                //    servicoBindingSource.DataSource = servicoBLL.BuscarPorNome(textBox_BuscarServico.Text);

                //}
                //else
                //{
                //    MessageBox.Show("Escolha a forma de busca");
                //}

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
