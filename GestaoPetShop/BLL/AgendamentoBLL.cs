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
        public Agendamento BuscarPorIdAnimalCliente(int _id, int _opc)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorIdAnimalCliente(_id, _opc);
        }

        public List<Agendamento> BuscarPorNomeAnimalCliente(string _nomeAnimalCliente, int _opc)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorNomeAnimalCliente(_nomeAnimalCliente, _opc);
        }
        public List<Agendamento> BuscarPorNomeProfissional(string _nomeProfissional, int _idProfissional)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorNomeProfissional(_nomeProfissional, _idProfissional);
        }

            public List<DataGridView1_FormsPrincipal> DataGridViewBuscarTodos()
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.DataGridViewBuscarTodos();

        }
        public List<DataGridView1_FormsPrincipal> DataGridViewBuscarPorId(int _idAgendamento , int _opc)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.DataGridViewBuscarPorId(_idAgendamento, _opc);
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

        public List<AgendamentoServico> BuscarServicoPorNome(string _nomeServico)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarServicoPorNome(_nomeServico);
        }

        public Servico PorNome(string _selectedText)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.PorNome(_selectedText);
        }
        public List<DataGridView1_FormsPrincipal> BuscarPorProfissional(string _nomeProfissional)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorProfissional(_nomeProfissional);
        }
    }
}
