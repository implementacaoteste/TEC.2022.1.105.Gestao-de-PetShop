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
            new RacaDAL().Alterar(_raca);   
        }
        public void Excluir(int _id)
        {
            new RacaDAL().Excluir(_id);
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
        public Raca BuscarPorId(int _id)
        {
            RacaDAL racaDAL = new RacaDAL();
            Raca raca = racaDAL.BuscarPorId(_id);
            if (raca.Id == 0)
            {
                throw new Exception("Raça não encontrada");
            }

            return raca;
        }
        public List<Raca> BuscarPorNome(string _nome)
        {
            RacaDAL racaDAL = new RacaDAL();

            List<Raca> racas = racaDAL.BuscarPorNome(_nome);
            if (racas.Count == 0)
            {
                throw new Exception("Nome não encontrado");
            }
            return racas;
        }
        public bool ExisteVinculo(int _id)
        {
            RacaBLL racaBLL = new RacaBLL();
            return racaBLL.ExisteVinculo(_id);
        }

        /* public List<Animal>BuscarPorEspecie(string _especie)
         {
             RacaDAL racaDAL = new RacaDAL();

             List<Raca> racas = racaDAL.BuscarPorNome(_especie);
             if (racas.Count == 0)
             {
                 throw new Exception("Especie não encontrada");
             }
             return racas;
         }*/

    }
}
