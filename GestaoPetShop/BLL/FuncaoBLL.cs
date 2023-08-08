using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FuncaoBLL
    {
        public void Inserir (Funcao _funcao)
        {
            FuncaoDAL funcaoDAL = new FuncaoDAL();
            funcaoDAL.Inserir(_funcao);
        }

        public void Alterar (Funcao _funcao)
        {
            FuncaoDAL funcaoDAL = new FuncaoDAL();
            funcaoDAL.Alterar(_funcao);

        }
        public void Excluir (int _id)
        {
            new ClienteDAL().Excluir(_id);

        }
        public List<Funcao> BuscarTodos()
        {
            return new FuncaoDAL().BuscarTodos();
        }
        public List<Funcao> BuscarPorNome(string _nome)
        {
            return new FuncaoDAL().BuscarPorNome(_nome);
        }
        public Funcao BuscarPorId(int _id)
        {
            return new FuncaoDAL().BuscarPorId(_id);
        }
    }
   
}
