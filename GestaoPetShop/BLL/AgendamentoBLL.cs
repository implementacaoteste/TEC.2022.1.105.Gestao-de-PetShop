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
            ValidarPreenchimento(_agendamento);
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            agendamentoDAL.Inserir(_agendamento);
        }

        private bool ValidarPreenchimento(Agendamento _agendamento)
        {
            if( _agendamento.IdAnimal == 0)
                throw new Exception("Animal não informado.");

            if ( _agendamento.IdSituacao == 0)
                throw new Exception("Situação não informada");

            if ( _agendamento.DataAg.Date < DateTime.Now.Date )
                throw new Exception("Data inválida ou não informada");

            if (String.IsNullOrEmpty (_agendamento.Horario))
                throw new Exception("Horário inválido.");

            if ( _agendamento.Total < 0)
                throw new Exception("Total inválido.");

            if( _agendamento.IdProfissional == 0)

            if (_agendamento.Ativo == false)
                throw new Exception("Ativo não marcado.");

            List<AgendamentoServico> agendamentoServicos = new List<AgendamentoServico>();
            agendamentoServicos = _agendamento.AgendamentoServicos;
            if (agendamentoServicos.Count < 1)
                throw new Exception("Não foi inserido serviços no agendamento.");

            return false;

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
            List<Agendamento> agendamentos = new List<Agendamento>();
            agendamentos =  agendamentoDAL.BuscarTodos(_opcSituacao, _opcAtivo);
            if(agendamentos.Count < 1)
            {
                throw new Exception("Agendamento não encontrado.");
                
            }
            return agendamentos;   
        }

       
        public Agendamento BuscarAgendamentoPorId(int _idAgendamento, int _opc)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            Agendamento agendamento = new Agendamento();
            agendamento = agendamentoDAL.BuscarAgendamentoPorId(_idAgendamento, _opc);
            if (agendamento == null || agendamento.Id == 0)
            {
                throw new Exception("Agendamento não encontrado.");

            }
            return agendamento;
            
        }
        public List<Agendamento> BuscarAgendamentoPorData(int _opc, string _data, int _opcAtivo, int _opcSituacao)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            List<Agendamento> agendamentos = new List<Agendamento>();
            agendamentos = agendamentoDAL.BuscarAgendamentoPorData(_opc, _data, _opcAtivo, _opcSituacao);
            if(agendamentos.Count < 1)
            {
                throw new Exception("Agendamento não encontrado");
            }
            return agendamentos;
        }
        public List<Agendamento> BuscarAgendamentoPorNomeCliente(string _nomeCliente, int _opcAtivo, int _opcSituacao)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            List<Agendamento> agendamentos = new List<Agendamento>();
            agendamentos = agendamentoDAL.BuscarAgendamentoPorNomeCliente(_nomeCliente, _opcAtivo,_opcSituacao);
            if(agendamentos.Count < 1)
            {
                throw new Exception("Agendamento não encontrado.");
            }
            return agendamentos;
        }
        public List<Agendamento> BuscarAgendamentoPorNomeProfissional(string _nomeProfissional, int _opcAtivo, int _opcSituacao)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            List<Agendamento> agendamentos = new List<Agendamento>();
            agendamentos = agendamentoDAL.BuscarAgendamentoPorNomeProfissional(_nomeProfissional, _opcAtivo, _opcSituacao);
            if (agendamentos.Count < 1)
            {
                throw new Exception("Agendamento não encontrado");
            }
            return agendamentos ;
        }
        public List<Agendamento> BuscarAgendamentoPorServicoData(string _nomeServico, string _data, int _opc, int _opcAtivo, int _opcSituacao)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            List<Agendamento> agendamentos = new List<Agendamento>();
            agendamentos = agendamentoDAL.BuscarAgendamentoPorServicoData(_nomeServico, _data,_opc,_opcAtivo,_opcSituacao);
            if(agendamentos.Count < 1)
            {
                throw new Exception("Agendamento não encontrado.");
            }
            return agendamentos;
        }
        public List<Agendamento> BuscarAgendamentoPorServico(string _nomeServico, int _opcAtivo, int _opcSituacao)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            List<Agendamento> agendamentos = new List<Agendamento>();
            agendamentos = agendamentoDAL.BuscarAgendamentoPorServico(_nomeServico, _opcAtivo, _opcSituacao);
            if (agendamentos.Count < 1)
            {
                throw new Exception("Agendmaento não encontrado");
            }
            return agendamentos;
        }
        public List<Agendamento> BuscarAgendamentoPorProfissionalData(string _nomeProfissional, string _data, int _opc,int _opcAtivo, int _opcSituacao)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            List<Agendamento> agendamentos = new List<Agendamento>();
            agendamentos = agendamentoDAL.BuscarAgendamentoPorProfissionalData(_nomeProfissional, _data, _opc, _opcAtivo, _opcSituacao);
            if(agendamentos.Count < 1)
            {
                throw new Exception("Agendamento não encontrado");
            }
            return agendamentos;
        }



        //----------------------------------------------------------------------
        
        public Cliente BuscarPorIdAnimalCliente(int _id, int _opc)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            Cliente cliente = new Cliente();
            cliente = agendamentoDAL.BuscarPorIdAnimalCliente(_id, _opc);
            if(cliente == null || cliente.Id <= 0)
            {
                throw new Exception("Cliente ou Animal não encontrado");
            }
            return cliente;
        }
        public List<Cliente> BuscarPorNomeAnimalCliente(string _nomeAnimalCliente, int _opc)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            List<Cliente> clientes = agendamentoDAL.BuscarPorNomeAnimalCliente(_nomeAnimalCliente, _opc);
            if (clientes.Count < 1)
            {
                throw new Exception("Cliente ou Animal não encontrado");
            }
            return clientes;
        }
        public List<Profissional> BuscarPorNomeProfissional(string _nomeProfissional, int _idProfissional)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            List<Profissional> profissionais = new List<Profissional>();
            profissionais = agendamentoDAL.BuscarPorNomeProfissional(_nomeProfissional, _idProfissional);
            if(profissionais.Count < 1)
            {
                throw new Exception("Profissional não encontrado.");
            }
            return profissionais;
        }
        public Profissional BuscarProfissional(string _nomeProfissional)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            Profissional profissional = new Profissional();
            profissional = agendamentoDAL.BuscarProfissional(_nomeProfissional);
            if(profissional == null || profissional.Id < 0)
            {
                throw new Exception("Profissional não encontrado.");
            }
            return profissional;
        }
        public Situacao BuscarSituacaoPorNome(string _descricaoSituacao)
        {
            AgendamentoDAL agendamentoDAL = new AgendamentoDAL();
            Situacao situacao = new Situacao();
           situacao = agendamentoDAL.BuscarSituacaoPorNome(_descricaoSituacao);
            if(situacao == null || situacao.Id < 0)
            {
                throw new Exception("Situação não encontrada.");
            }
            return situacao;
        }
    }
}
