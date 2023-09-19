using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicoBLL
    {
        public void Inserir(Servico _servico)
        {
            ValidarPreenchimento(_servico);
            ServicoDAL servicoDAL = new ServicoDAL();
            servicoDAL.Inserir(_servico);
        }

        private void ValidarPreenchimento(Servico _servico)
        {
            if (String.IsNullOrEmpty(_servico.Descricao))
                throw new Exception("A descrição do serviço não foi preenchida.");

            if (_servico.Preco == 0)
                throw new Exception("O Preço do serviço não foi preenchido.");

            if (_servico.Tempo == 0)
                throw new Exception("O tempo de serviço não foi preenchido.");

            if(_servico.Id == 0)
            {
                if (_servico.Ativo == false)
                    throw new Exception("O Ativo do serviço não foi preenchido");
            }
        }

        public List<Servico> BuscarTodos()
        {

            ServicoDAL servicoDAL = new ServicoDAL();
            List<Servico> servicos = servicoDAL.BuscarTodos();
            if (servicos.Count == 0)
            {
                throw new Exception("Não tem serviço cadastrado") { Data = { { "Id", 47 } } };
            }
            return servicos;
        }
        public Servico BuscarPorId(int _id)
        {

            if(_id == 0)
                throw new Exception("Id Inválido ou não informado");

            ServicoDAL servicoDAL = new ServicoDAL();
            Servico servico = servicoDAL.BuscarPorId(_id);

            if (servico.Id == 0)
            {
                throw new Exception("Serviço não encontrado") { Data = { { "Id", 48 } } };
            }

            return servico;
        }
        public List<Servico> BuscarPorNome(string _nome)
        {
           
            
            ServicoDAL servicoDAL = new ServicoDAL();

            List<Servico> servicos = servicoDAL.BuscarPorNome(_nome);
            if (servicos.Count == 0)
            {
                throw new Exception("Serviço não encontrado") { Data = { { "Id", 49 } } };
            }
            return servicos;
        }
        public void Alterar(Servico _servico)
        {
            ValidarPreenchimento(_servico);
            ServicoDAL servicoDAL = new ServicoDAL();
            servicoDAL.Alterar(_servico);
        }
        public void Excluir(int _id)
        {
            if (new ServicoBLL().ExisteVinculo(_id))
            {
                throw new Exception("Este Serviço foi utilizado em agendamento. Deve ser excluído primeiro o registro em agendamento.") { Data = { { "Id", 50 } } };
            }
            ServicoDAL servicoDAL = new ServicoDAL();
            servicoDAL.Excluir(_id);
        }
        public bool ExisteVinculo(int _id)
        {
            ServicoDAL servicoDAL = new ServicoDAL();
            return servicoDAL.ExisteVinculo(_id);
        }
    }
}
