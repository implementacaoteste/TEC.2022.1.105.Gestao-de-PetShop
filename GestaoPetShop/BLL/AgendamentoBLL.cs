using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<DataGridView1_FormsPrincipal> BuscarPorNomeCliente(string _nomeCliente)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorNomeCliente(_nomeCliente);
        }

        public List<DataGridView1_FormsPrincipal> BuscarPorDiaMesAno(string _diaMesAno)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorDiaMesAno(_diaMesAno);
        }

        public object BuscarPorMesAno(int _opc,string _mesAno)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorMesAno(_opc,_mesAno);
        }

        public List<DataGridView_Servico> BuscarsServicoPorNome(string _nomeServico)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarsServicoPorNome(_nomeServico);
        }

        public Servico PorNome(string _selectedText)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.PorNome(_selectedText);
        }
        //public List<DataGridView_Servico> BuscarsServicoPorAno(string _nomeAno)
        //{
        //    AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
        //    return agendamentoDAL.BuscarsServicoPorAno(_nomeAno);
        //}
    }
}
