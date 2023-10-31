using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPetShop
{
    public partial class FormMainHome : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FormMainHome()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            try
            {
                int index = random.Next(ThemeColor.ColorList.Count);
                while (tempIndex == index)
                {
                    index = random.Next(ThemeColor.ColorList.Count);
                }
                tempIndex = index;
                string color = ThemeColor.ColorList[index];
                return ColorTranslator.FromHtml(color);

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao gerar uma cor aleatório.", ex) { Data = { { "Id", 332 } } };
            }
        }
        private void ActivateButton(object btnSender)
        {
            try
            {
                if (btnSender != null)
                {
                    if (currentButton != (Button)btnSender)
                    {
                        DisableButton();
                        Color color = SelectThemeColor();
                        currentButton = (Button)btnSender;
                        currentButton.BackColor = color;
                        currentButton.ForeColor = Color.White;
                        currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        panelTitleBar.BackColor = color;
                        panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                        ThemeColor.PrimaryColor = color;
                        ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                        btnCloseChildForm.Visible = true;

                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao formatar os botão ao formulário.", ex) { Data = { { "Id", 333 } } };
            }
        }
        private void DisableButton()
        {
            try
            {
                foreach (Control previousBtn in panelMenu.Controls)
                {
                    if (previousBtn.GetType() == typeof(Button))
                    {
                        previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                        previousBtn.ForeColor = Color.Gainsboro;
                        previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao desativar a função do botão.", ex) { Data = { { "Id", 334 } } };
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            try
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                ActivateButton(btnSender);
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelDesktopPane.Controls.Add(childForm);
                this.panelDesktopPane.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                labelTitle.Text = childForm.Text;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um formatar os formulários secundários.", ex) { Data = { { "Id", 335 } } };
            }

        }
        private void buttonPrincipal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPrincipal(), sender);
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormConsultaUsuario(), sender);
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormConsultaCliente(), sender);
        }

        private void buttonServico_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormConsultaServico(), sender);
        }

        private void buttonAgendamento_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormConsultaAgendamento(), sender);
        }

        private void buttonAnimal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormConsultaAnimal(), sender);
        }

        private void buttonRaca_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormConsultaRaca(), sender);
        }

        private void buttonProfissional_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormConsultaProfissional(), sender);
        }

        private void buttonFuncao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormConsultaFuncao(), sender);
        }

        private void buttonRelatorio_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRelatorioGeral(), sender);
        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            try
            {
                DisableButton();
                labelTitle.Text = "HOME";
                panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
                panelLogo.BackColor = Color.FromArgb(39, 39, 58);
                currentButton = null;
                btnCloseChildForm.Visible = false;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao executar o reset.", ex) { Data = { { "Id", 336 } } };
            }
        }

        private void FormMainHome_Load(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                using (FormLogin frm = new FormLogin())
                {
                    frm.ShowDialog();
                    if (!frm.Logou)
                        Application.Exit();
                    lblUsuarioLogado.Text = Constantes.UsuarioLogado;
                }
                this.Visible = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao executar o formuário de login.", ex) { Data = { { "Id", 337 } } };
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //try
            //{
            //    if (WindowState == FormWindowState.Normal)
            //        this.WindowState = FormWindowState.Maximized;
            //    else
            //        this.WindowState = FormWindowState.Normal;

            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("Ocorreu um erro no botão maximizar.", ex) { Data = { { "Id", 338 } } };
            //}
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();

            label1.Text = DateTime.Now.ToLongTimeString();

            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void buttonLogOff_Click(object sender, EventArgs e) // givas testando
        {


            try
            {
                using (FormMainHome frm = new FormMainHome())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
