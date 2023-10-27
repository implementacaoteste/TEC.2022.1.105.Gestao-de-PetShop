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
            new UsuarioBLL().ValidarPermissao(14);
            ValidarDados(_raca);
            RacaDAL racaDAL = new RacaDAL();
            racaDAL.Inserir(_raca);
        }

        private void ValidarDados(Raca _raca)
        {
            if (String.IsNullOrEmpty(_raca.Nome))
                throw new Exception("Digite o nome da Raça");

            
           


            if (String.IsNullOrEmpty(_raca.Especie))
                throw new Exception(_raca.Especie);

            if (_raca.Id == 0)
            {
                if (_raca.Ativo == false)
                    throw new Exception("Marque o Ativo");

                List<Raca> racas = new RacaDAL().BuscarPorNome(_raca.Nome);
                if (racas.Count > 0)
                {

                    bool aux = false;
                    StringBuilder rc = new StringBuilder();
                    foreach (Raca ra in racas)
                    {
                        if (aux)
                            rc.Append("\n ");

                        rc.Append(ra.Id + "," + ra.Nome);
                        aux = true;
                    }
                    throw new Exception("Raça já cadastrada \n" + rc.ToString());
                }
            }
            else
            {
                Raca raca = new RacaBLL().BuscarPorId(_raca.Id);
                if (_raca.Ativo != raca.Ativo)
                    new UsuarioBLL().ValidarPermissao(37);
            }
        }

        public void Alterar(Raca _raca)
        {
            new UsuarioBLL().ValidarPermissao(23);
            new RacaDAL().Alterar(_raca);   
        }
        public void Excluir(int _id)
        {
            new UsuarioBLL().ValidarPermissao(32);
            new RacaDAL().Excluir(_id);
        }
        public List<Raca> BuscarTodos()
        {
            new UsuarioBLL().ValidarPermissao(5);
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
            new UsuarioBLL().ValidarPermissao(5);
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
            new UsuarioBLL().ValidarPermissao(5);
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
