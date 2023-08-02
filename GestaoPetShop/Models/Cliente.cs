﻿using System;
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
        public string CPF { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; } 
        public string UF { get; set; }
        public string Pais { get; set; }
        public string CEP { get; set; }
        public int DataNascimento { get; set; }
        
        //public string Foto { get; set; }

        public bool Ativo { get; set; }



    }
}