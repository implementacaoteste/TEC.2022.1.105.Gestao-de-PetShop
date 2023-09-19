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
            if (String.IsNullOrEmpty(_funcao.Nome))
                throw new Exception("Não foi inserido nome para a função.");

            FuncaoDAL funcaoDAL = new FuncaoDAL();
            funcaoDAL.Inserir(_funcao);
        }
        public void Alterar (Funcao _funcao)
        {
            if (String.IsNullOrEmpty(_funcao.Nome))
                throw new Exception("Não foi inserido nome para a função.");

            FuncaoDAL funcaoDAL = new FuncaoDAL();
            funcaoDAL.Alterar(_funcao);

        }
        public void Excluir (int _id)
        {

            if (ExisteVinculaDeFuncaoComProfissional(_id))
            {
                throw new Exception("Esta função não pode ser excluída enquanto tiver vículo com profissional.");
            }

            new FuncaoDAL().Excluir(_id);

        }

        private bool ExisteVinculaDeFuncaoComProfissional(int _idfuncao)
        {
           return new FuncaoDAL().ExisteVinculaDeFuncaoComProfissional(_idfuncao);
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

        public void InserirPermissaoNaFuncao(int _idFuncao, int _idPermissao)
        {
            new FuncaoDAL().InserirPermissaoNaFuncao(_idFuncao, _idPermissao);
        }

        public void RemoverPermissaoDeFuncao(int _idFuncao, int _idPermissao)
        {
            new FuncaoDAL().RemoverPermissaoDeFuncao(_idFuncao,_idPermissao);
        }
    }
   
}
