using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RacaBLL
    {
        public void Inserir(Raca _raca)
        {
            RacaDAL racaDAL = new RacaDAL();
            racaDAL.Inserir(_raca);
        }
        public void Alterar(Raca _raca)
        {
            RacaDAL racaDAL = new RacaDAL();
            racaDAL.Alterar(_raca);
        }
        public void Excluir(int _id)
        {
            RacaDAL racaDAL = new RacaDAL();
            racaDAL.Excluir(_id);
        }
        public List<Raca> BuscarTodos()
        {
            RacaDAL racaDAL = new RacaDAL();
            List<Raca> racas = racaDAL.BuscarTodos();
            if (racas.Count == 0)
            {
                throw new Exception("Não tem raças cadastrado");
            }
            return racas;
        }

    }
}
