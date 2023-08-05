using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; } 
        public string UF { get; set; }
        public string Pais { get; set; }
        public int CEP { get; set; }
        public int DataNascimento { get; set; }
        public byte[] Foto { get; set; }
        public bool Ativo { get; set; }


    }
}