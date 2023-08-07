using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Agendamento
    {
        public int Id  { get; set; }
        public int IdAnimal { get; set; }
        public int IdProfissional { get; set; }
        public int IdSituacao { get; set; }
        public int DataAg { get; set; }
        public int Horario { get; set; }
        public int Total { get; set; }
        public bool Ativo { get; set; }

       
    }
}
