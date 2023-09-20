using Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Web.UI.WebControls;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario) // Dimas
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Usuario(UsuarioLogin, IdProfissional, Senha, Ativo) 
                                    VALUES(@UsuarioLogin, @IdProfissional, @Senha, @Ativo)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@UsuarioLogin", _usuario.UsuarioLogin);
                cmd.Parameters.AddWithValue("@IdProfissional", _usuario.IdProfissional);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Usuario> BuscarTodos() // dimas
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT U.Id, U.UsuarioLogin, U.IdProfissional, U.Senha,U.Ativo, P.Nome FROM Usuario U" +
                                                                    " INNER JOIN Profissional P ON U.IdProfissional = P.Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.UsuarioLogin = rd["UsuarioLogin"].ToString();
                        usuario.IdProfissional = Convert.ToInt32(rd["IdProfissional"]);
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuario.NomeProfissional = rd["Nome"].ToString();
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuários no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public Usuario BuscarPorId(int _id) // dimas
        {
            Usuario usuario = new Usuario();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT U.Id, U.UsuarioLogin, U.IdProfissional, U.Senha,U.Ativo, P.Nome FROM Usuario U 
                                                                   INNER JOIN Profissional P ON U.IdProfissional = P.Id
                                                                    WHERE U.Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.UsuarioLogin = rd["UsuarioLogin"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.IdProfissional = Convert.ToInt32(rd["IdProfissional"]);
                        usuario.NomeProfissional = rd["Nome"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuários no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Usuario> BuscarPorLogin(string _login) // DIMAS
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT U.Id, U.UsuarioLogin, U.IdProfissional, U.Senha,U.Ativo, P.Nome FROM Usuario U" +
                                                                   " INNER JOIN Profissional P ON U.IdProfissional = P.Id" +
                                                                   "WHERE UPPER(UsuarioLogin) LIKE UPPER(@Login)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Login","%" + _login + "%");

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.UsuarioLogin = rd["UsuarioLogin"].ToString();
                        usuario.IdProfissional = Convert.ToInt32(rd["IdProfissional"]);
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuario.NomeProfissional = rd["Nome"].ToString();
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("ocorreu um erro ao tentar buscar id do usuário do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Usuario BuscarPorLoginAutenticar(string _login) // DIMAS
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = new Usuario(); ;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, UsuarioLogin, IdProfissional, Senha,Ativo FROM Usuario WHERE UsuarioLogin LIKE @Login";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Login", _login);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                       
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.UsuarioLogin = rd["UsuarioLogin"].ToString();
                        usuario.IdProfissional = Convert.ToInt32(rd["IdProfissional"]);
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                      
                      
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("ocorreu um erro ao tentar buscar id do usuário do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Usuario SET UsuarioLogin = @UsuarioLogin, IdProfissional = @IdProfissional, Senha = @Senha , Ativo = @Ativo
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@UsuarioLogin", _usuario.UsuarioLogin);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Id", _usuario.Id);
                cmd.Parameters.AddWithValue("@IdProfissional", _usuario.IdProfissional);
                cmd.Parameters.AddWithValue("@Ativo",_usuario.Ativo);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar um usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE Id = @Id", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", _id);
                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }
                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;
                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir usuário no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
      
        public bool ValidarPermissao(int _idUsuarioLogado, int _idPermissao)//Givas
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 FROM  Usuario LEFT JOIN Profissional ON Usuario.IdProfissional = Profissional.Id
                                                LEFT JOIN Funcao ON Profissional.IdFuncao = Funcao.Id
                                                LEFT JOIN FuncaoPermissao ON Funcao.Id = FuncaoPermissao.IdFuncao
                                                LEFT JOIN Permissao ON FuncaoPermissao.IdPermissao = Permissao.Id
                                                WHERE Usuario.IdProfissional = @IdUsuario AND Permissao.Id = @IdPermissao";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuarioLogado);
                cmd.Parameters.AddWithValue("@IdPermissao", _idPermissao);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar validar permissões do usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
       
       

        public List<Usuario> BuscarPorNomeProfissional(string _nomeProfissional) // dimas
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT U.Id, U.UsuarioLogin, U.IdProfissional, U.Senha,U.Ativo, P.Nome FROM Profissional P" +
                                                                                    "INNER JOIN Usuario U ON P.Id = U.IdProfissional" +
                                                                                    "WHERE UPPER(P.Nome) LIKE UPPER(@Nome)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nomeProfissional + "%");

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.UsuarioLogin = rd["UsuarioLogin"].ToString();
                        usuario.IdProfissional = Convert.ToInt32(rd["IdProfissional"]);
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuario.NomeProfissional = rd["Nome"].ToString();
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("ocorreu um erro ao tentar buscar id do usuário do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public Usuario BucarPorIdProfissional(int _idProfissional)
        {
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT U.Id, U.UsuarioLogin, U.IdProfissional, U.Senha,U.Ativo, P.Nome FROM Usuario U" +
                                                               " INNER JOIN Profissional P ON U.IdProfissional = P.Id" +
                                                               " WHERE IdProfissional = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _idProfissional);
                
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.UsuarioLogin = rd["UsuarioLogin"].ToString();
                        usuario.IdProfissional = Convert.ToInt32(rd["IdProfissional"]);
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuario.NomeProfissional = rd["Nome"].ToString();
                       
                    }
                }
                return usuario;
            }
            catch (Exception)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar Usuário no Banco de Dados.");
            }
            finally { cn.Close(); }

        }
    }
}
