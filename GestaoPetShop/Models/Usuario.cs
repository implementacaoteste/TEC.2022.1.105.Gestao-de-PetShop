using System.Collections.Generic;

namespace Models
{
    public class Usuario
    {
        public int Id { get; set; }
        //public string Nome { get; set; }//Givas
        public string UsuarioLogin { get; set; }
        public string Senha { get; set; }
        //public string Email { get; set; }//Givas
        //public string CPF { get; set; }//Givas
        public int IdProfissional { get; set; }
        public bool Ativo { get; set; }
        public List<GrupoUsuario> GrupoUsuarios { get; set; }//Givas
    }
}