﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Funcao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Permissao> Permissoes { get; set; }
    }
}
