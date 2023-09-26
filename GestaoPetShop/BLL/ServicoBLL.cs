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
            ServicoDAL servicoDAL = new ServicoDAL();
            servicoDAL.Inserir(_servico);
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

        public Servico BuscarPorNomeUnico(string _nome)
        {
            ServicoDAL servicoDAL = new ServicoDAL();

            Servico servico = servicoDAL.BuscarPorNomeUnico(_nome);
            if (servico.Id == 0)
            {
                throw new Exception("Serviço não encontrado") { Data = { { "Id", 0 } } };
            }
            return servico;
        }
    }
}
