using System.Collections.Generic;

namespace Models
{
    public class GrupoUsuario
    {
        public int Id { get; set; }
        public string NomeGrupo { get; set; }
        public List<Permissao> Permissoes { get; set; }
    }
}
