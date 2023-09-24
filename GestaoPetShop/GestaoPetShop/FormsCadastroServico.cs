using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormsCadastroServico : Form
    {
        int id;
        public FormsCadastroServico(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }
        
        private void FormsCadastroServico_Load(object sender, EventArgs e)
        {
            //this.Hide();
            try
            {
                if (id == 0)
                {
                    label1CadastrarServico.Visible = true;
                    label2_AlterarServico.Visible = false;
                    servicoBindingSource.AddNew();
                }
                else
                {
                    label1CadastrarServico.Visible = false;
                    label2_AlterarServico.Visible = true;
                    servicoBindingSource.DataSource = new ServicoBLL().BuscarPorId(id);
                }
                
                    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_SalvarServico_Click(object sender, EventArgs e)
        {
            try
            {
                servicoBindingSource.EndEdit();
                ServicoBLL servicoBLL = new ServicoBLL();
               
                if (id == 0)
                {
                    servicoBLL.Inserir((Servico)servicoBindingSource.Current);
                    MessageBox.Show("Cadastrado com sucesso!");
                    //Close();
                }
                else
                {
                    servicoBLL.Alterar((Servico)servicoBindingSource.Current);
                    MessageBox.Show("Alterado com sucesso!");
                    //Close();

                }
            }
            catch (Exception ex)
            {
                if (new TratarErro().GetId(ex) == 40)//referente a inserir em Dal
                    descricaoTextBox.Focus();

                if (new TratarErro().GetId(ex) == 44)// referente a alterar em DAL
                    descricaoTextBox.Focus();

                if (new TratarErro().GetId(ex) == 47)// referente inserir em BLl
                       descricaoTextBox.Focus();

                if (new TratarErro().GetId(ex) == 48)// referente inserir em BLl
                    precoTextBox.Focus();

                if (new TratarErro().GetId(ex) == 49)// referente inserir em BLl
                    tempoTextBox.Focus();

                if (new TratarErro().GetId(ex) == 50)// referente inserir em BLl
                    ativoCheckBox.Focus();


                MessageBox.Show(ex.Message);
            }
        }

        private void button_CancelarCadastroOuAlterar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
