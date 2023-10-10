using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoPetShop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
         {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //MessageBox.Show(new Criptografia().CriptografarSenha("sdfgtAHK4523512"));

            Logs.Gravar("Usuario abriu o sistema");
            Application.Run(new FormMainHome());
            Logs.Gravar("Usuario fechou o sistema");
        }
    }
}