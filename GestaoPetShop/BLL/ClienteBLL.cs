using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace BLL
{
    public class ClienteBLL
    {
        public void Inserir(Cliente _cliente)
        {
            new UsuarioBLL().ValidarPermissao(11);
            ValidarDados(_cliente);
            new ClienteDAL().Inserir(_cliente);
        }
        private void ValidarDados(Cliente _cliente)
        {
            DateTime dateTime = Convert.ToDateTime("01/01/0001");

            if (String.IsNullOrEmpty(_cliente.Nome))
                throw new Exception("Informe o nome do cliente.");

            if (String.IsNullOrEmpty(_cliente.CPF))
                throw new Exception("Informe o CPF do cliente.");
            if(_cliente.Id == 0)
            {
                Cliente cliente = new ClienteBLL().BuscarPorCPF(_cliente.CPF);
                

                if (_cliente.CPF == cliente.CPF)
                {
                    throw new Exception("CPF já cadastrado \n" + "Id "+cliente.Id +" Nome: "+ cliente.Nome );
                }
            }

            if (_cliente.DataNascimento.Date == dateTime)
                throw new Exception("Informe o data de nascimento do cliente.");

            if (String.IsNullOrEmpty(_cliente.UF))
                throw new Exception("Informe o UF do cliente.");

            if (String.IsNullOrEmpty(_cliente.CEP))
                throw new Exception("Informe o CEP do cliente.");

            if (String.IsNullOrEmpty(_cliente.Cidade))
                throw new Exception("Informe o cidade do cliente.");

            if (String.IsNullOrEmpty(_cliente.Pais))
                throw new Exception("Informe o país do cliente.");

            if (String.IsNullOrEmpty(_cliente.Bairro))
                throw new Exception("Informe o bairro do cliente.");

            if (String.IsNullOrEmpty(_cliente.Numero))
                throw new Exception("Informe o número do cliente.");

            if (String.IsNullOrEmpty(_cliente.Logradouro))
                throw new Exception("Informe o logradouro do cliente.");

            if (_cliente.Id == 0)
            {

                if (_cliente.Ativo == false)
                    throw new Exception("Ativo não marcado.");

            }
            else
            {
                Cliente cliente = new ClienteBLL().BuscarPorId(_cliente.Id);
                if(_cliente.Ativo != cliente.Ativo)
                {
                    new UsuarioBLL().ValidarPermissao(37);
                }
            }

            List<TelefoneCliente> telefoneClientes = new List<TelefoneCliente>();
            telefoneClientes = _cliente.TelefoneClientes;
            if (telefoneClientes.Count < 1)
                throw new Exception("Não foi inserido telefone.");

        }
        public List<Cliente> BuscarTodos()
        {
            new UsuarioBLL().ValidarPermissao(2);
            return new ClienteDAL().BuscarTodos();
        }
        public List<Cliente> BuscarPorNome(string _nome)
        {
            new UsuarioBLL().ValidarPermissao(2);
            return new ClienteDAL().BuscarPorNome(_nome);
        }
        public Cliente BuscarPorId(int _id)
        {
            new UsuarioBLL().ValidarPermissao(2);
            return new ClienteDAL().BuscarPorId(_id);
        }
        public Cliente BuscarPorCPF(string _CPF)
        {
            new UsuarioBLL().ValidarPermissao(2);
            if (String.IsNullOrEmpty(_CPF))
                throw new Exception("Informe um CPF") { Data = { { "Id", 17 } } };

            return new ClienteDAL().BuscarPorCPF(_CPF);
        }
        public void Alterar(Cliente _cliente)
        {
            new UsuarioBLL().ValidarPermissao(20);
            ValidarDados(_cliente);
            new ClienteDAL().Alterar(_cliente);
        }
        public void Excluir(Cliente _cliente)
        {
            new UsuarioBLL().ValidarPermissao(29);
            if (new ClienteDAL().ExisteVinculoClienteComAgendamento(_cliente.Id))
            {
                throw new Exception("Não é possível excluir este cliente.\nO cliente está vinculado em um agendamento");
            }

            new ClienteDAL().Excluir(_cliente);
        }
    }
}
