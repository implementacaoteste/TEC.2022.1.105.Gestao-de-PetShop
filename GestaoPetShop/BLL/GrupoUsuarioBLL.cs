using Models;
using System.Collections.Generic;
using System;
using DAL;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario _grupoUsuario)
        {
            new UsuarioBLL().ValidarPermissao(6);
            new GrupoUsuarioDAL().Inserir(_grupoUsuario);
        }
        public List<GrupoUsuario> BuscarTodos()
        {
            return new GrupoUsuarioDAL().BuscarTodos();
        }
        public List<GrupoUsuario> BuscarPorNomeGrupo(string _nomeGrupo)
        {
            return new GrupoUsuarioDAL().BuscarPorNomeGrupo(_nomeGrupo);
        }
        public List<GrupoUsuario> BuscarPorId(int _id)
        {
            return new GrupoUsuarioDAL().BuscarPorId(_id);
        }
        public void Alterar(GrupoUsuario _grupoUsuario)
        {
            new GrupoUsuarioDAL().Alterar(_grupoUsuario);
        }
        public void Excluir(int _id)
        {
            new GrupoUsuarioDAL().Excluir(_id);
        }
        public void AdicionarPermissao(int _idGrupo, int _idPermissao)
        {
            if (!new GrupoUsuarioDAL().PermissaoVinculada(_idGrupo, _idPermissao))
                new GrupoUsuarioDAL().AdicionarPermissao(_idGrupo, _idPermissao);
        }
        public void RemoverPermissao(int _idGrupo, int _idPermissao)
        {
            new GrupoUsuarioDAL().RemoverPermissao(_idGrupo, _idPermissao);
        }
    }
}
