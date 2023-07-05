using System.Collections.Generic;

namespace Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int IdProfissional { get; set; }
    }
}