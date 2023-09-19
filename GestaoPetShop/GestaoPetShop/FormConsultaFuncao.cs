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
    public partial class FormConsultaFuncao : Form
    {
        public FormConsultaFuncao()
        {
            InitializeComponent();
        }//Givas
        private void btnBuscarFuncao_Click(object sender, EventArgs e)
        {
            try
            {
                FuncaoBLL funcaoBLL = new FuncaoBLL();
                if (comboBoxEscolhaBuscarFuncao.SelectedIndex == 0)
                {
                    funcaoBindingSource.DataSource = funcaoBLL.BuscarTodos();
                }
                else if (comboBoxEscolhaBuscarFuncao.SelectedIndex == 1)
                {
                    funcaoBindingSource.DataSource = funcaoBLL.BuscarPorId(Convert.ToInt32(textBoxBuscarFuncao.Text));
                }
                else if (comboBoxEscolhaBuscarFuncao.SelectedIndex == 2)
                {
                    funcaoBindingSource.DataSource = funcaoBLL.BuscarPorNome(textBoxBuscarFuncao.Text);
                }
                else
                {
                    MessageBox.Show("Escolha a forma de buscar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//Givas
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            using (FormCadastroFuncao frm = new FormCadastroFuncao())
            {
                try
                {
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }//Givas
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcaoBindingSource.Count == 0)
                {
                    MessageBox.Show("Não foi selecionado o Função para ser alterado.");
                    return;
                }
                int id = ((Funcao)funcaoBindingSource.Current).Id;

                using (FormCadastroFuncao frm = new FormCadastroFuncao(id))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }//Givas
       
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (funcaoBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro selecionado para ser excluído");
                    return;
                }
                if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((Funcao)funcaoBindingSource.Current).Id;
              
                new FuncaoBLL().Excluir(id);
                funcaoBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//Givas

        private void buttonVincularPermissaoEmFuncao_Click(object sender, EventArgs e)
        {
            try
            {
                if(funcaoBindingSource.Count <= 0)
                {
                    MessageBox.Show("Selecione uma função.");
                    return ;
                }
                int idfuncao = ((Funcao)funcaoBindingSource.Current).Id;
                string nomefuncao = ((Funcao)funcaoBindingSource.Current).Nome;
                using(FormVincularPermissaoEmFuncao frm = new FormVincularPermissaoEmFuncao(idfuncao, nomefuncao))
                {
                    frm.ShowDialog();
                    
                }
                if (comboBoxEscolhaBuscarFuncao.SelectedIndex == 0)
                {
                    funcaoBindingSource.DataSource = new FuncaoBLL().BuscarTodos();
                }
                else if (comboBoxEscolhaBuscarFuncao.SelectedIndex == 1)
                {
                    funcaoBindingSource.DataSource = new FuncaoBLL().BuscarPorId(Convert.ToInt32(textBoxBuscarFuncao.Text));
                }
                else if (comboBoxEscolhaBuscarFuncao.SelectedIndex == 2)
                {
                    funcaoBindingSource.DataSource = new FuncaoBLL().BuscarPorNome(textBoxBuscarFuncao.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDesvincularPermissaoDeFuncao_Click(object sender, EventArgs e)
        {
            try
            {
                if(permissoesBindingSource.Count < 1)
                {
                    MessageBox.Show("Selecione uma permissão para excluir.");
                    return;
                }
                if (MessageBox.Show("Deseja Remover esta Permissão da Função?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int idfuncao = ((Funcao)funcaoBindingSource.Current).Id;
                int idpermissao = ((Permissao)permissoesBindingSource.Current).Id;


                new FuncaoBLL().RemoverPermissaoDeFuncao(idfuncao, idpermissao);

                if (comboBoxEscolhaBuscarFuncao.SelectedIndex == 0)
                {
                    funcaoBindingSource.DataSource = new FuncaoBLL().BuscarTodos();
                }
                else if (comboBoxEscolhaBuscarFuncao.SelectedIndex == 1)
                {
                    funcaoBindingSource.DataSource = new FuncaoBLL().BuscarPorId(Convert.ToInt32(textBoxBuscarFuncao.Text));
                }
                else if (comboBoxEscolhaBuscarFuncao.SelectedIndex == 2)
                {
                    funcaoBindingSource.DataSource = new FuncaoBLL().BuscarPorNome(textBoxBuscarFuncao.Text);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
