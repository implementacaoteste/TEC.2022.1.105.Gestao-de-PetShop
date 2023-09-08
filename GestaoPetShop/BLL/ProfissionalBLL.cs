using DAL;
using Models;
using System;
using System.Collections.Generic;

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
                throw new Exception("Informe o nome do cliente.");
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
        public void Excluir(int _id)
        {
            new ProfissionalDAL().Excluir(_id);
        }//Givas
        public Profissional BuscarPorId(int _id)//Givas
        {
            return new ProfissionalDAL().BuscarPorId(_id);
        }
        public Profissional BuscarPorCPF(string _CPF)//Givas
        {
            if (String.IsNullOrEmpty(_CPF))
                throw new Exception("Informe um CPF") { Data = { { "Id", -1 } } };

            return new ProfissionalDAL().BuscarPorCPF(_CPF);
        }
    }
}
