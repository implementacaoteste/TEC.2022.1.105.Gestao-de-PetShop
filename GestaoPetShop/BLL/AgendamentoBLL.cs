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
using System.Xml.Linq;

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
        //______________________________________________________________________

        public List<Agendamento> BuscarTodos(int _opcSituacao,int _opcAtivo)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarTodos(_opcSituacao, _opcAtivo);
        }
        public Agendamento BuscarAgendamentoPorId(int _idAgendamento, int _opc)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarAgendamentoPorId(_idAgendamento, _opc);
        }
        public List<Agendamento> BuscarAgendamentoPorData(int _opc, string _mesAno, int _opcAtivo, int _opcSituacao)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarAgendamentoPorData(_opc, _mesAno,_opcAtivo,_opcSituacao);
        }
        public List<Agendamento> BuscarAgendamentoPorNomeCliente(string _nomeCliente, int _opcAtivo, int _opcSituacao)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarAgendamentoPorNomeCliente(_nomeCliente, _opcAtivo,_opcSituacao);
        }
        public List<Agendamento> BuscarAgendamentoPorNomeProfissional(string _nomeProfissional, int _opcAtivo, int _opcSituacao)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarAgendamentoPorNomeProfissional(_nomeProfissional, _opcAtivo, _opcSituacao);
        }
        public List<Agendamento> BuscarAgendamentoPorServicoData(string _nomeServico, string _data, int _opc, int _opcAtivo, int _opcSituacao)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarAgendamentoPorServicoData(_nomeServico, _data,_opc,_opcAtivo,_opcSituacao);
        }
        public List<Agendamento> BuscarAgendamentoPorServico(string _nomeServico, int _opcAtivo, int _opcSituacao)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarAgendamentoPorServico(_nomeServico, _opcAtivo, _opcSituacao);
        }
        public List<Agendamento> BuscarAgendamentoPorProfissionalData(string _nomeProfissional, string _data, int _opc,int _opcAtivo, int _opcSituacao)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarAgendamentoPorProfissionalData(_nomeProfissional, _data, _opc, _opcAtivo, _opcSituacao);
        }



        //----------------------------------------------------------------------
        
        public Cliente BuscarPorIdAnimalCliente(int _id, int _opc)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorIdAnimalCliente(_id, _opc);
        }
        public List<Cliente> BuscarPorNomeAnimalCliente(string _nomeAnimalCliente, int _opc)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorNomeAnimalCliente(_nomeAnimalCliente, _opc);
        }
        public List<Profissional> BuscarPorNomeProfissional(string _nomeProfissional, int _idProfissional)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            return agendamentoDAL.BuscarPorNomeProfissional(_nomeProfissional, _idProfissional);
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

      
       
    }
}
