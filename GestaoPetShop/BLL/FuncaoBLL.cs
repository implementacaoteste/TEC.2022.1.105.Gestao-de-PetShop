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
            new UsuarioBLL().ValidarPermissao(18);
            if (String.IsNullOrEmpty(_funcao.Nome))
                throw new Exception("Não foi inserido nome para a função.") { Data = { { "Id", 31 } } };

            FuncaoDAL funcaoDAL = new FuncaoDAL();
            funcaoDAL.Inserir(_funcao);
        }
        public void Alterar (Funcao _funcao)
        {
            new UsuarioBLL().ValidarPermissao(27);
            if (String.IsNullOrEmpty(_funcao.Nome))
                throw new Exception("Não foi inserido nome para a função.") { Data = { { "Id", 32 } } };

            FuncaoDAL funcaoDAL = new FuncaoDAL();
            funcaoDAL.Alterar(_funcao);

        }
        public void Excluir (int _id)
        {
            new UsuarioBLL().ValidarPermissao(36);
            if (ExisteVinculaDeFuncaoComProfissional(_id))
            {
                throw new Exception("Esta função não pode ser excluída enquanto tiver vículo com profissional.") { Data = { { "Id", 33 } } }; ;
            }

            new FuncaoDAL().Excluir(_id);

        }

        private bool ExisteVinculaDeFuncaoComProfissional(int _idfuncao)
        {
           return new FuncaoDAL().ExisteVinculaDeFuncaoComProfissional(_idfuncao);
        }

        public List<Funcao> BuscarTodos()
        {
            new UsuarioBLL().ValidarPermissao(9);
            List<Funcao> funcoes = new List<Funcao>();
            funcoes = new FuncaoDAL().BuscarTodos();
            if(funcoes.Count < 1)
            {
                throw new Exception("Função não encontrada");
            }
            return funcoes;
        }
        public List<Funcao> BuscarPorNome(string _nome)
        {
            new UsuarioBLL().ValidarPermissao(9);
            List<Funcao> funcoes = new List<Funcao>();
            funcoes = new FuncaoDAL().BuscarPorNome(_nome);
            if (funcoes.Count < 1)
            {
                throw new Exception("Função não encontrada");
            }
            return funcoes;
        }
        public Funcao BuscarPorId(int _id)
        {
            new UsuarioBLL().ValidarPermissao(9);
            Funcao funcao = new Funcao();

           funcao = new FuncaoDAL().BuscarPorId(_id);
            if(funcao.Id == 0)
            {
                throw new Exception("Função não encontrada");
            }
            return funcao;
        }

        public void InserirPermissaoNaFuncao(int _idFuncao, int _idPermissao)
        {
            new UsuarioBLL().ValidarPermissao(36);// mesma função que tem a permissão de excluir
            new FuncaoDAL().InserirPermissaoNaFuncao(_idFuncao, _idPermissao);
        }

        public void RemoverPermissaoDeFuncao(int _idFuncao, int _idPermissao)
        {
            new UsuarioBLL().ValidarPermissao(36); // mesma função que tem a permissão de excluir
            new FuncaoDAL().RemoverPermissaoDeFuncao(_idFuncao,_idPermissao);
        }
    }
   
}
