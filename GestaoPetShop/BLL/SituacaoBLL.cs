using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SituacaoBLL
    {
        public void Inserir(Situacao _situacao)
        {
            SituacaoDAL situacaoDAL = new SituacaoDAL();
            situacaoDAL.Inserir(_situacao);
        }
        public List<Situacao> BuscarTodos()
        {
            SituacaoDAL situacaoDAL = new SituacaoDAL();
            List<Situacao> situacaos = situacaoDAL.BuscarTodos();
            if (situacaos.Count == 0)
            {
                throw new Exception("Serviço não cadastrado");
            }
            return situacaos;
        }
        public Situacao BuscarPorId(int _id)
        {
            SituacaoDAL situacaoDAL = new SituacaoDAL();
            Situacao situacao = situacaoDAL.BuscarPorId(_id);
            if (situacao.Id == 0)
            {
                throw new Exception("Serviço não encontrado");
            }
            return situacao;
        }
        public List<Situacao> BuscarPorNome(string _nome)
        {
            SituacaoDAL situacaoDAL = new SituacaoDAL();

            List<Situacao> situacaos = situacaoDAL.BuscarPorNome(_nome);
            if (situacaos.Count == 0)
            {
                throw new Exception("Serviço não encontrado");
            }
            return situacaos;
        }
        public void Alterar(Situacao _situacao)
        {
            SituacaoDAL situacaoDAL = new SituacaoDAL();
            situacaoDAL.Alterar(_situacao);
        }
        public void Excluir(int _id)
        {
            if (new SituacaoBLL().ExisteVinculo(_id))
            {
                throw new Exception("Este Serviço foi utilizado em uma Situação. Deve ser excluído primeiro o registro em Situação.");
            }
            SituacaoDAL situacaoDAL = new SituacaoDAL();
            situacaoDAL.Excluir(_id);
        }
        private bool ExisteVinculo(int _id)
        {
            SituacaoDAL situacaoDAL = new SituacaoDAL();
            return situacaoDAL.ExisteVinculo(_id);
        }
    }
}
