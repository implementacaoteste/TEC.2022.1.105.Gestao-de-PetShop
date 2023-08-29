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
        public void Alterar(Agendamento _agendamento, List<AgendamentoServico> _servicosParaExcluir)//
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            agendamentoDAL.Alterar(_agendamento, _servicosParaExcluir);//
        }
        public void Excluir(Agendamento _agendamento)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            agendamentoDAL.Excluir(_agendamento);
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
        public List<Profissional> BuscarPorNomeProfissional(string _nomeProfissional, int _idProfissional)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorNomeProfissional(_nomeProfissional, _idProfissional);
        }
        public List<Agendamento> BuscarPorNomeCliente(string _nomeCliente)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorNomeCliente(_nomeCliente);
        }
        public List<Agendamento> BuscarPorDiaMesAno(string _diaMesAno)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorDiaMesAno(_diaMesAno);
        }
        public List<Agendamento> BuscarPorMesAno(int _opc, string _mesAno)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorMesAno(_opc, _mesAno);
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
        public List<Agendamento> BuscarPorProfissional(string _nomeProfissional)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorProfissional(_nomeProfissional);
        }
        public Profissional BuscarProfissional(string _nomeProfissional)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarProfissional(_nomeProfissional);
        }
        public Situacao BuscarSituacaoPorNome(string _descricaoSituacao)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarSituacaoPorNome(_descricaoSituacao);
        }
        public Agendamento BuscarAgendamentoPorId(int _idAgendamento, int _opc)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarAgendamentoPorId(_idAgendamento, _opc);
        }
        public void ExcluirServicoDeAgendamento(int _idservico, int _idagendamento)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            agendamentoDAL.ExcluirServicoDeAgendamento(_idservico, _idagendamento);
        }
        public List<Agendamento> BuscarTodos()
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarTodos();
        }
        public Animal BuscarPorIdAnimal(int _idpesquisa)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorIdAnimal(_idpesquisa);
        }
        public Cliente BuscarPorIdCliente(int _idCliente)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorIdCliente(_idCliente);
        }

        public List<Agendamento> BuscarAgendamentoPorNomeProfissional(string _nomeProfissional)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarAgendamentoPorNomeProfissional(_nomeProfissional);
        }

        public List<Agendamento> BuscarAgendamentoPorServicoDiaMesAno(string _nomeServico, string _data)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarAgendamentoPorServicoDiaMesAno(_nomeServico, _data);
        }
    }
}
