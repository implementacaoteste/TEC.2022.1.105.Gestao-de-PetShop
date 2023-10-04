using System;
using System.IO;

namespace Models
{
    public static class Constantes
    {
        public static int IdUsuarioLogado;
        public static string UsuarioLogado;
        public static string StringDeConexao;
        public static string DiretorioStringConexao = "C:\\Configuracao\\";
        public static string CaminhoChavePublica = "C:\\Configuracao\\ChavePublica.txt";
        public static string CaminhoChavePrivada = "C:\\Configuracao\\ChavePrivada.txt";
        public static string NomeArquivoConexao = "petShopConnection.config";
        public static string DiretorioArquivoLog = Environment.CurrentDirectory + "\\Logs\\";

        public static string CaminhoArquivoLog
        {
            get
            {
                Directory.CreateDirectory(DiretorioArquivoLog);
                return DiretorioArquivoLog + "Log" + DateTime.Now.Year.ToString() +
                    DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00") + ".log";
            }

        }
    }
}
