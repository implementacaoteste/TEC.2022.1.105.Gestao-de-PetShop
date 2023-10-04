using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public static class Logs
    {
        public static void Gravar(string _text)
        {
            string caminho = @"C:\Configuracao\Log" + DateTime.Now.Year.ToString() +
                                                     DateTime.Now.Month.ToString() +
                                                     DateTime.Now.Day.ToString() + ".txt";
            string texto = DateTime.Now.ToString() + ": " + _text;
            new Arquivo().GravarLinhaNoFinalDoArquivo(caminho, texto);
        }
    }
}
