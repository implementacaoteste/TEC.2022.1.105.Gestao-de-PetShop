using DAL;
using Models;
using Infra;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario, string _confirmacaoDeSenha)
        {
            ValidarPermissao(10);

            ValidarDados(_usuario, _confirmacaoDeSenha);
            _usuario.Senha = new Criptografia().CriptografarSenha(_usuario.Senha);

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }
        public void Alterar(Usuario _usuario, string _confirmacaoDeSenha)
        {
            ValidarPermissao(19);

            ValidarDados(_usuario, _confirmacaoDeSenha);
            _usuario.Senha = new Criptografia().CriptografarSenha(_usuario.Senha);
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Alterar(_usuario);
        }
        public void Excluir(int _id)
        {
            ValidarPermissao(28);
            new UsuarioDAL().Excluir(_id);
        }
        public List<Usuario> BuscarTodos()
        {
            ValidarPermissao(1);
            return new UsuarioDAL().BuscarTodos();
        }
        public Usuario BuscarPorId(int _id)
        {
            ValidarPermissao(1);
            return new UsuarioDAL().BuscarPorId(_id);
        }
        public List<Usuario> BuscarPorLogin(string _login)
        {
            ValidarPermissao(1);
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = usuarioDAL.BuscarPorLogin(_login);
            if (usuarios != null && usuarios.Count < 1)
            {
                throw new Exception("Login não encontrado.");
            }
            return usuarios;
        }
        private void ValidarDados(Usuario _usuario, string _confirmacaoDeSenha)
        {
            if (_usuario.Senha != _confirmacaoDeSenha)
                throw new Exception("A senha e a confirmação da senha devem ser iguais.");

            if (_usuario.Senha.Length <= 3)
                throw new Exception("A senha deve ter mais de 3 caracteres.") { Data = { { "Id", 30 } } };

            if (_usuario.UsuarioLogin.Length <= 2)
                throw new Exception("O Login deve ter mais de 2 caracteres.");

            if (_usuario.Id == 0)
            {
                if (_usuario.Ativo != true)
                {
                    throw new Exception("Ativo não está marcado");
                }
            }
            else
            {
                Usuario usuario = new UsuarioBLL().BuscarPorId(_usuario.Id);

                if (_usuario.Ativo != usuario.Ativo)
                {
                    ValidarPermissao(37);
                }
            }

        }
        public void ValidarPermissao(int _idPermissao)
        {
            if (!new UsuarioDAL().ValidarPermissao(Constantes.IdUsuarioLogado, _idPermissao))
                throw new Exception("Você não tem permissão de realizar essa operação. Procure o administrador do sistema.");
        }
        public void Autenticar(string _nomeUsuario, string _senha)
        {
            Usuario usuario = new UsuarioDAL().BuscarPorLoginAutenticar(_nomeUsuario);
            string senha = new Criptografia().CriptografarSenha(_senha);
            if (senha == usuario.Senha && usuario.Ativo)
            {
                Constantes.IdUsuarioLogado = usuario.Id;
                Constantes.UsuarioLogado = usuario.UsuarioLogin;
            }
            else
                throw new Exception("Usuario ou senha inválido.");
        }
        public List<Usuario> BuscarPorNomeProfissional(string _nomeProfissional)
        {
            ValidarPermissao(1);
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = usuarioDAL.BuscarPorNomeProfissional(_nomeProfissional);
            if (usuarios != null && usuarios.Count < 1)
            {
                throw new Exception("Profissional não encontrado.");
            }
            return usuarios;
            //return new UsuarioDAL().BuscarPorNomeProfissional(_nomeProfissional);
        }
        public Usuario BucarPorIdProfissional(int _idProfissional)
        {
            ValidarPermissao(1);
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            Usuario usuario = new Usuario();
            usuario = usuarioDAL.BuscarPorId(_idProfissional);
            if (usuario == null || usuario.IdProfissional == 0)
            {
                throw new Exception("Usuário não localizado.");
            }
            return usuario;
            //return new UsuarioDAL().BucarPorIdProfissional(_idProfissional);
        }
        public bool VerificarSenhaAtual(string _txtSenhaAtual, int _id)
        {
            string senhaatual = BuscarPorId(_id).Senha;
            string txtSenhaAtual = new Criptografia().CriptografarSenha(_txtSenhaAtual);
            if (senhaatual == txtSenhaAtual)
                return false;
            else
                return true;
        }
    }
}
