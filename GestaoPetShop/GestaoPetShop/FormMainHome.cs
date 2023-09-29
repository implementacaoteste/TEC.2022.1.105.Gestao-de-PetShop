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
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

        private Color SelectThemeColor()
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
        private void ActivateButton(object btnSender)
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
        private void DisableButton()
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
        private void OpenChildForm(Form childForm, object btnSender)
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
            DisableButton();
            labelTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void FormMainHome_Load(object sender, EventArgs e)
        {
            try
            {
                using (FormLogin frm = new FormLogin())
                {
                    frm.ShowDialog();
                    if (!frm.Logou)
                        Application.Exit();
                    lblUsuarioLogado.Text = Constantes.UsuarioLogado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        //private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}
    }
}
