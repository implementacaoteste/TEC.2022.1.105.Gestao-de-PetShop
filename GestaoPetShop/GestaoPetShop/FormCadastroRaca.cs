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
using static Guna.UI2.Native.WinApi;

namespace GestaoPetShop
{
    public partial class FormCadastroRaca : Form
    {


        int id;
        bool permitirSalvar;
        public FormCadastroRaca(int _id = 0, bool _permitirSalvar = true)
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


                Raca raca = (Raca)racaBindingSource.Current;
                racaBindingSource.EndEdit();


                if (id == 0)
                    new RacaBLL().Inserir(raca);
                else
                    new RacaBLL().Alterar(raca);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroRaca_Load(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                LoadTheme();

                if (id == 0)
                {
                    label1CadastrarRaca.Visible = true;
                    label2AlterarRaca.Visible = false;
                    racaBindingSource.AddNew();
                }
                else
                {
                    label1CadastrarRaca.Visible = false;
                    label2AlterarRaca.Visible = true;
                    racaBindingSource.AddNew();
                    racaBindingSource.DataSource = new RacaBLL().BuscarPorId(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.Focus();
        }

        //private void buttonCancelar_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}
    }
}
