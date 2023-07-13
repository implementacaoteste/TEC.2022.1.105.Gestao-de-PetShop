using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
            return servicoDAL.BuscarTodos();
        }
        public Servico BuscarPorId(int _id)
        {
           
            try
            {
                ServicoDAL servicoDAL = new ServicoDAL();
                return servicoDAL.BuscarPorId(_id);
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os Serviços no banco de dados treta.", ex) { Data = { { "Id", 45 } } };
            }

        }
        public void Alterar(Servico _servico)
        {
            ServicoDAL servicoDAL = new ServicoDAL();
            servicoDAL.Alterar(_servico);
        }
        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            ServicoDAL servicoDAL = new ServicoDAL();
            servicoDAL.Excluir(_id);
        }

    }
}
