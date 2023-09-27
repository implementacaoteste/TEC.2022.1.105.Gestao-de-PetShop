using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario, string _confirmacaoDeSenha)
        {
            //ValidarPermissao(10);
            ValidarDados(_usuario, _confirmacaoDeSenha);

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }
        public void Alterar(Usuario _usuario, string _confirmacaoDeSenha)
        {
            //ValidarPermissao(3);
            ValidarDados(_usuario, _confirmacaoDeSenha);

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Alterar(_usuario);
        }
        public void Excluir(int _id)
        {
            //ValidarPermissao(4);
            new UsuarioDAL().Excluir(_id);
        }
       
        public List<Usuario> BuscarTodos()
        {
            //ValidarPermissao(1);
            return new UsuarioDAL().BuscarTodos();
        }
        public Usuario BuscarPorId(int _id)
        {
            //ValidarPermissao(1);
            return new UsuarioDAL().BuscarPorId(_id);
        }
        public List<Usuario> BuscarPorLogin(string _login)
        {
            //ValidarPermissao(1);
            return new UsuarioDAL().BuscarPorLogin(_login);
        }
        private void ValidarDados(Usuario _usuario, string _confirmacaoDeSenha)
        {
            if (_usuario.Senha != _confirmacaoDeSenha)
                throw new Exception("A senha e a confirmação da senha devem ser iguais.");

            if (_usuario.Senha.Length <= 3)
                throw new Exception("A senha deve ter mais de 3 caracteres.") { Data = { { "Id", 123 } } };

            if (_usuario.UsuarioLogin.Length <= 2)
                throw new Exception("O Login deve ter mais de 2 caracteres.");
        }
        public void ValidarPermissao(int _idPermissao)
        {
            if (!new UsuarioDAL().ValidarPermissao(Constantes.IdUsuarioLogado, _idPermissao))
                throw new Exception("Você não tem permissão de realizar essa operação. Procure o administrador do sistema.");
        }
        public void Autenticar(string _nomeUsuario, string _senha)
        {
            Usuario usuario = new UsuarioDAL().BuscarPorLoginAutenticar(_nomeUsuario);
            if (_senha == usuario.Senha && usuario.Ativo)
            {
                Constantes.IdUsuarioLogado = usuario.Id;
                Constantes.UsuarioLogado = usuario.UsuarioLogin;
            }
            else
                throw new Exception("Usuario ou senha inválido.");
        }
        public List<Usuario> BuscarPorNomeProfissional(string _nomeProfissional)
        {
            return new UsuarioDAL().BuscarPorNomeProfissional(_nomeProfissional);
        }
        public Usuario BucarPorIdProfissional(int _idProfissional)
        {
            return new UsuarioDAL().BucarPorIdProfissional(_idProfissional);
        }
    }
}
