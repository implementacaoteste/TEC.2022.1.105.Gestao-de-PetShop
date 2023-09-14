using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PermissaoBLL
    {
        public void Inserir(Permissao _permissao)//Givas
        {
            //new PermissaoDAL().Inserir(_permissao);
            if (_permissao.Descricao.Length <= 10 || _permissao.Descricao.Length >= 50)
                throw new Exception("A descrição da permissao de usuário deve ter ais de 10 caracteres.");

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Inserir(_permissao);
        }
        public List<Permissao> BuscarTodos()
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            List<Permissao> permissaos = permissaoDAL.BuscarTodos();
            if (permissaos.Count == 0)
            {
                throw new Exception("Permissão não cadastrado");
            }
            return permissaos;
        }//Givas
        public List<Permissao> BuscarPermissaoPorNome(string _nomePermissao)
        {
            //return new PermissaoDAL().BuscarPorDescricao(_descricao);
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            List<Permissao> permissaos = permissaoDAL.BuscarPermissaoPorNome(_nomePermissao);
            if (permissaos.Count == 0)
            {
                throw new Exception("Serviço de buscar por nome não encontrado em permissão");
            }
            return permissaos;
        }//Givas
        public List<Permissao> BuscarPorId(int _id)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            List<Permissao> permissaos = permissaoDAL.BuscarPorId(_id);
            if (permissaos.Count == 0)
            {
                throw new Exception("Serviço de buscar por id não encontrado");
            }
            return permissaos;
        }//Givas
        public void Alterar(Permissao _permissao)
        {
            new PermissaoDAL().Alterar(_permissao);
            if (_permissao.Descricao.Length <= 3 || _permissao.Descricao.Length >= 250)
                throw new Exception("A alteração informada deverá conter de 3 a 250 caracteres.");

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Alterar(_permissao);
        }//Givas
        public void Excluir(int _id)
        {
            new PermissaoDAL().Excluir(_id);
        }//Givas
    }
}
