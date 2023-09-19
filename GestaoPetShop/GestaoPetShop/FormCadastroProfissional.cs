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
    public partial class FormCadastroProfissional : Form
    {
        int id;
        bool permitirSalvar;
        public FormCadastroProfissional(int _id = 0, bool _permitirSalvar = true)
        {
            InitializeComponent();
            id = _id;
            buttonSalvar.Visible = _permitirSalvar;
            permitirSalvar = _permitirSalvar;
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!permitirSalvar)
                    return;
                profissionalBindingSource.EndEdit();
                Profissional profissional = (Profissional)profissionalBindingSource.Current;

                if (id == 0)
                    new ProfissionalBLL().Inserir(profissional);
                else
                    new ProfissionalBLL().Alterar(profissional);

                MessageBox.Show("Registro salvo com sucesso.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormCadastroProfissional_Load(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                    profissionalBindingSource.AddNew();
                   
                else
                    btnGerarSenha.Visible = true;
                profissionalBindingSource.DataSource = new ProfissionalBLL().BuscarPorId(id);

                if (!permitirSalvar)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (!item.Name.Contains("DataGridView"))
                            item.Enabled = false;
                    }
                }

                List<Funcao> funcoes = new List<Funcao>();
                funcoes = new FuncaoBLL().BuscarTodos();

                int num2 = funcoes.Count();
                for (int x = 0; x < num2; x++)
                {
                    nomeFuncaoComboBox.Items.Insert(x, funcoes[x].Nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            profissionalBindingSource.CancelEdit();
        }
        private void buttonBuscarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoDaImagem = openFileDialog.FileName;
                pictureBoxFoto.Image = Image.FromFile(caminhoDaImagem);
            }
        }
        private void buttonInserirEmail_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                MessageBox.Show("O campo do E-mail não estar preenchido.");
                return;
            }
            emailProfissionalBindingSource.AddNew();
            ((EmailProfissional)emailProfissionalBindingSource.Current).Email = textBoxEmail.Text;
            emailProfissionalBindingSource.EndEdit();
            textBoxEmail.Text = "";

        }
        private void buttonInserirTelefone_Click(object sender, EventArgs e)
        {
            if (textBoxTelefone.Text == "")
            {
                MessageBox.Show("O campo do Telefone não estar preenchido.");
                return;
            }
            telefoneProfissionalBindingSource.AddNew();
            ((TelefoneProfissional)telefoneProfissionalBindingSource.Current).Telefone = textBoxTelefone.Text;
            telefoneProfissionalBindingSource.EndEdit();
            textBoxTelefone.Text = "";
        }
        private void buttonExcluirEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (profissionalBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }

                if (MessageBox.Show("Deseja realmente excluir este registro ?", "Atenção !", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((EmailProfissional)emailProfissionalBindingSource.Current).Id;
                new EmailProfissionalBLL().Excluir(id);
                emailProfissionalBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonExcluirTelefone_Click(object sender, EventArgs e)
        {
            try
            {
                if (profissionalBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído.");
                    return;
                }
                if (MessageBox.Show("Deseja realmente excluir este registro ?", "Atenção !", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                int id = ((TelefoneProfissional)telefoneProfissionalBindingSource.Current).Id;
                new TelefoneProfissionalBLL().Excluir(id);
                telefoneProfissionalBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void nomeFuncaoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Funcao> funcoes = new List<Funcao>();
            funcoes = new FuncaoBLL().BuscarPorNome(nomeFuncaoComboBox.Text);

            int num2 = funcoes.Count();
            for (int x = 0; x < num2; x++)
            {
                idFuncaoTextBox.Text = funcoes[x].Id.ToString();
                ((Profissional)profissionalBindingSource.Current).IdFuncao = Convert.ToInt32(funcoes[x].Id);
                    //Insert(x, Convert.ToString(funcoes[x].Id));
            }
        }
        private void btnGerarSenha_Click(object sender, EventArgs e)
        {
            using (FormGerarSenha frm = new FormGerarSenha())
            {
                frm.ShowDialog();
            }
        }
    }
}
