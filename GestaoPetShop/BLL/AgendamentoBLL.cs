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
    public class AgendamentoBLL
    {
        public void Inserir(Agendamento _agendamento)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            agendamentoDAL.Inserir(_agendamento);
        }
        public Agendamento BuscarPorId(int _id)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorId(_id);
        }
        public void Alterar(Agendamento _agendamento)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            agendamentoDAL.Alterar(_agendamento);
        }
        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            agendamentoDAL.Excluir(_id);
        }

        public object BuscarPorNomeAnimal(string _nomeAnimal)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorNomeAnimal(_nomeAnimal);
        }

        public List<DataGridView1_FormsPrincipal> DataGridViewBuscarTodos()
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.DataGridViewBuscarTodos();

        }
        public List<DataGridView1_FormsPrincipal> DataGridViewBuscarPorId(int _idAgendamento)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.DataGridViewBuscarPorId(_idAgendamento);
        }

    }
}
