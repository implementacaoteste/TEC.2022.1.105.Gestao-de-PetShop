using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class Criptografia
    {
        private RSA rsa;
        public Criptografia()
        {
            rsa = RSA.Create();
        }
        public string CriptografarSenha(string _senha)
        {
            string retorno = _senha;
            for(int i = 0; i < retorno.Length; i++)
            {
                retorno = ReverterTexto(retorno);
                retorno = GerarHast(retorno);
            }
            
            return GerarHast(retorno);
        }
        private string GerarHast(string _texto)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(_texto));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        private string ReverterTexto(string _texto)
        {
            char[] charArray = _texto.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
