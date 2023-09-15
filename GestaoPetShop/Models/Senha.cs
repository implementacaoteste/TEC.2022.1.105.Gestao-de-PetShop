using System;

namespace Models
{
    public static class Senha
    {
        public static string GerarSenha(byte digitos)
        {
            var senha = "";
            var caracteres = "ABCDEFGHIJKLMNOPQRSTUVXYWZ_0123456789!@#$%&()_0123456789!@#$%&()abcdefghijklmnopqrstuvxywz";
            var tamanho = caracteres.Length;
            Random numero = new Random();

            for (int i = 0; i < digitos; i++)
                senha += caracteres[numero.Next(tamanho)];

            return senha;
        }
    }
}
