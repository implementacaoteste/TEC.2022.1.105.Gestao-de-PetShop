using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Profissional
    {
        public int Id { get; set; }
        public int IdFuncao  { get; set; } 
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Largradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        public int CEP { get; set; }
        public int DataNascimento { get; set; }
        public byte Foto { get; set; }
        public bool Ativo { get; set; }


    }
}
