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
        public string Nome { get; set; } 
        public string DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public int IdFuncao { get; set; }
        public bool Ativo { get; set; }
        public byte Foto { get; set; }

    }
}
