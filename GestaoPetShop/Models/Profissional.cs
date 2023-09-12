using System;
using System.Collections.Generic;

namespace Models
{
    public class Profissional
    {
        public int Id { get; set; }
        public int IdFuncao  { get; set; }
        public string NomeFuncao { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        public string CEP { get; set; }
        public DateTime DataNascimento { get; set; }
        public byte[] Foto { get; set; }
        public bool Ativo { get; set; }
        public List<TelefoneProfissional> TelefoneProfissional { get; set; }//Givas
        public List<EmailProfissional> EmailProfissional { get; set; }//Givas
        public Profissional()
        {
            TelefoneProfissional = new List<TelefoneProfissional>();
            EmailProfissional = new List<EmailProfissional>();
        }//Givas
    }
}
