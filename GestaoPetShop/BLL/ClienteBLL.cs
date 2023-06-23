using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class ClienteBLL
    {
        public void Inserir(Cliente _cliente)
        {
            new ClienteDAL().Inserir(_cliente);
        }
        public List<Cliente> BuscarTodos()
        {
            return new ClienteDAL().BuscarTodos();
        }
        public List<Cliente> BuscarPorNome(string _nome)
        {
            return new ClienteDAL().BuscarPorNome(_nome);
        }
        public Cliente BuscarPorId(int _id)
        {
           return new ClienteDAL().BuscarPorId(_id);
        }
        public Cliente BuscarPorCPF(string _CPF)
        {
            if (String.IsNullOrEmpty(_CPF))
                throw new Exception("Informe um CPF") { Data = { { "Id", 32 } } };

            return new ClienteDAL().BuscarPorCPF(_CPF);
        }
        public void Alterar(Cliente _cliente)
        {
            new ClienteDAL().Alterar(_cliente);
        }
        public void Excluir(int _id)
        {
            new ClienteDAL().Excluir(_id);
        }
    }
}
