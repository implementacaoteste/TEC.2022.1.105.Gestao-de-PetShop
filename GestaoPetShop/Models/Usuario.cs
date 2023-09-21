using System.Collections.Generic;

namespace Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string UsuarioLogin { get; set; }
        public string Senha { get; set; }
        public int IdProfissional { get; set; }
        public bool Ativo { get; set; }
        public string NomeProfissional { get; set; }

    }
}