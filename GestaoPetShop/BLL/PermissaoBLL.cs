using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class PermissaoBLL
    {
        public void Inserir(Permissao _permissao)
        {
            if (_permissao.Nome.Length <= 10 || _permissao.Nome.Length >= 50)
                throw new Exception("A descrição da permissao de usuário deve ter ais de 10 caracteres.");

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Inserir(_permissao);
        }
        public List<Permissao> BuscarTodos()
        {
            return new PermissaoDAL().BuscarTodos();
        }
        public List<Permissao> BuscarPorNome(string _nome)
        {
            return new PermissaoDAL().BuscarPorNome(_nome);
        }
        public List<Permissao> BuscarPorId(int _id)
        {
            return new PermissaoDAL().BuscarPorId(_id);
        }
        public void Alterar(Permissao _permissao)
        {
            if (_permissao.Nome.Length <= 3 || _permissao.Nome.Length >= 250)
                throw new Exception("A alteração informada deverá conter de 3 a 250 caracteres.");

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Alterar(_permissao);
        }
        public void Excluir(Permissao _permissao)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Excluir(_permissao);
        }
    }
}
