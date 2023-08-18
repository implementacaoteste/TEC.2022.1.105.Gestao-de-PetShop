using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EmailCliente
    {   
        public int Id { get; set; } 
        public int IdCliente { get; set; }
        public string Email { get; set; }
    }
}
