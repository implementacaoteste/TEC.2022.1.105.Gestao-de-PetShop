using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Animal
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdRaca { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public string Agressivo { get; set; }
        public string Cor { get; set; }
        public int Idade { get; set; }
        public string Alergia { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
        public string NomeRaca
        {
            get
            {
                if (Raca != null)
                    return Raca.Nome;

                return "";
            }
        }
        public string NomeCliente
        {
            get
            {
                if (Cliente != null)
                    return Cliente.Nome;

                return "";
            }
        }
        public Raca Raca { get; set; }
        public Cliente Cliente { get; set; }

    }
}
