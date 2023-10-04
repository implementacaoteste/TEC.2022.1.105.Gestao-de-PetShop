using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class Arquivo
    {
        public void GravarLinhaNoFinalDoArquivo(string _caminhoArquivo, string _text)
        {
            

            using(StreamWriter arquivo = File.AppendText(_caminhoArquivo))
            {
                arquivo.WriteLine(_text);
            }
        }
        public void GravarBytesNoFinalDoAquivo(string _caminhoArquivo, byte[] _bytes)
        {
            ExcluirArquivo(_caminhoArquivo);
            using(FileStream arquivo = new FileStream(_caminhoArquivo, FileMode.Append))
            {
                if (!File.Exists(_caminhoArquivo))
                {
                    byte[] novaLinhaBytes = Encoding.UTF8.GetBytes(Environment.NewLine);
                    arquivo.Write(novaLinhaBytes, 0, novaLinhaBytes.Length);
                }
                arquivo.Write(_bytes, 0, _bytes.Length);
            }
        }


        public void ExcluirArquivo(string _arquivo)
        {
            if(File.Exists(_arquivo))
                File.Delete(_arquivo);
        }
    }
   
}
