using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class ProfissionalBLL
    {
        public void Inserir(Profissional _profissional)
        {
            new ProfissionalDAL().Inserir(_profissional);
        }
        public List<Profissional> BuscarTodos()
        {
            //return new ProfissionalDAL().BuscarTodos();
            throw new NotImplementedException();
        }
        public List<Profissional> BuscarPorNome(string _nome)
        {
            //return new ProfissionalDAL().BuscarPorNome(_nome);
            throw new NotImplementedException();
        }

      

        public void Alterar(Profissional _profissional)
        {
            new ProfissionalDAL().Alterar(_profissional);
        }
        public void Excluir(int _id)
        {
            //new ProfissionalDAL().Excluir(_id);
            throw new NotImplementedException();
        }
    }
}
