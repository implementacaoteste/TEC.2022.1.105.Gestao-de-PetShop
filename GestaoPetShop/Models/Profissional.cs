using System.Collections.Generic;

namespace Models
{
    public class Profissional
    {
        public int Id { get; set; }
        public int IdFuncao  { get; set; } 
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        public int CEP { get; set; }
        public int DataNascimento { get; set; }
        public byte Foto { get; set; }
        public bool Ativo { get; set; }
        //public List<Profissional> Profissionais { get; set; }

    }
}
