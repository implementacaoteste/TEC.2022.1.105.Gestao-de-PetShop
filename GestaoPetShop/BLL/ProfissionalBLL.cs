﻿using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ProfissionalBLL
    {
        public void Inserir(Profissional _profissional)
        {
            ValidarDados(_profissional);
            new ProfissionalDAL().Inserir(_profissional);
        }
        private void ValidarDados(Profissional _profissional)//Givas
        {
            if (String.IsNullOrEmpty(_profissional.Nome))
                throw new Exception("Informe o nome do profissional.") { Data = { { "Id", 39 } } };

            if (String.IsNullOrEmpty(_profissional.NomeFuncao))
                throw new Exception("Informe o Função do profissional.") { Data = { { "Id", 39 } } };

            if (String.IsNullOrEmpty(_profissional.Logradouro))
                throw new Exception("Informe o Logradouro do profissional.") { Data = { { "Id", 39 } } };

            if (String.IsNullOrEmpty(_profissional.Bairro))
                throw new Exception("Informe o Bairro do profissional.") { Data = { { "Id", 39 } } };

            if (String.IsNullOrEmpty(_profissional.Cidade))
                throw new Exception("Informe o Cidade do profissional.") { Data = { { "Id", 39 } } };


            string verificacao = Convert.ToString(_profissional.DataNascimento.Date);

            if (verificacao.Count() != 19)
                throw new Exception("Informe a Data de nascimento do profissional.") { Data = { { "Id", 39 } } };

            if (_profissional.CPF.Count() != 14)
                throw new Exception("CPF incorreto.") { Data = { { "Id", 39 } } };

            if(_profissional.Id == 0)
            {
                Profissional profissional = new ProfissionalBLL().BuscarPorCPF(_profissional.CPF);

                if(_profissional.CPF == profissional.CPF)
                {
                    throw new Exception("CPF já cadastrado.\n"+"Id: "+profissional.Id + "Nome: "+ profissional.Nome) { Data = { { "Id", 39 } } };
                }
            }


            if(_profissional.Ativo != true)
                throw new Exception("Informe o Ativo do profissional.") { Data = { { "Id", 39 } } };

            if(_profissional.CEP.Count() != 9)
                throw new Exception("Informe o CEP do profissional.") { Data = { { "Id", 39 } } };

            if(_profissional.UF.Count() != 2)
                throw new Exception("Informe o UF do profissional.") { Data = { { "Id", 39 } } };

            if (_profissional.IdFuncao < 0)
                throw new Exception("Informe o Id da Função do profissional.") { Data = { { "Id", 39 } } };

            if (_profissional.TelefoneProfissional.Count < 1)
                throw new Exception("Informe o Telefone do profissional.") { Data = { { "Id", 39 } } };


        }
        public List<Profissional> BuscarTodos()
        {
            return new ProfissionalDAL().BuscarTodos();
        }
        public List<Profissional> BuscarPorNome(string _nome)
        {
            return new ProfissionalDAL().BuscarPorNome(_nome);
        }
        public void Alterar(Profissional _profissional)
        {
            new ProfissionalDAL().Alterar(_profissional);
        }
        public void Excluir(Profissional  _profissional)
        {
            if(new ProfissionalDAL().ExisteVinculoProfissionalComAgendamentoServico(_profissional.Id))
            {
                throw new Exception("O profissional pode ser excluido.\nProfissional está vinculado a um agendamento.");
            }

            new ProfissionalDAL().Excluir(_profissional);
        }//Givas
        public Profissional BuscarPorId(int _id)//Givas
        {
            return new ProfissionalDAL().BuscarPorId(_id);
        }
        public Profissional BuscarPorCPF(string _CPF)//Givas
        {
            if (String.IsNullOrEmpty(_CPF))
                throw new Exception("Informe um CPF") { Data = { { "Id", 40 } } };

            return new ProfissionalDAL().BuscarPorCPF(_CPF);
        }
    }
}
