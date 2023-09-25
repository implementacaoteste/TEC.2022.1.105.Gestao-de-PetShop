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

           try
            {
                if (id == 0)
                    racaBindingSource.AddNew();
                else
                    racaBindingSource.DataSource = new RacaBLL().BuscarPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
