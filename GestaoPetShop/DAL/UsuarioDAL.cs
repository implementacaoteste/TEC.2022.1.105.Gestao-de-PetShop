using Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario)
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
        public List<Usuario> BuscarTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, UsuarioLogin, IdProfissional, Senha FROM Usuario";
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
        public List<Usuario> BuscarPorNomeUsuario(string _usuarioLogin)
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id,IdProfissional, UsuarioLogin, Senha FROM Usuario WHERE UPPER (UsuarioLogin) LIKE UPPER (@UsuarioLogin)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@UsuarioLogin", "%" + _usuarioLogin + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())

                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.IdProfissional = Convert.ToInt32(rd["IdProfissional"]);
                        usuario.UsuarioLogin = rd["UsuarioLogin"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        usuarios.Add(usuario);
                    }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar usuario no banco de dados.", ex) { Data = { { "Id", 58 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Usuario BuscarPorId(int _id)
        {
            Usuario usuario = new Usuario();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, UsuarioLogin, IdProfissional, Senha FROM Usuario 
                                    WHERE Id = @Id";
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
        public Usuario BuscarPorLogin(string _login)
        {
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, UsuarioLogin, Senha, IdProfissional, Ativo FROM Usuario WHERE UsuarioLogin = @Login";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Login", _login);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.UsuarioLogin = rd["UsuarioLogin"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.IdProfissional = Convert.ToInt32(rd["IdProfissional"]);
                        usuario.Ativo = rd["Ativo"] == DBNull.Value ? false : Convert.ToBoolean(rd["Ativo"]);
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
                cmd.CommandText = @"UPDATE Usuario SET Login = @UsuarioLogin, IdProfissional = @IdProfissional, Senha = @Senha 
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@UsuarioLogin", _usuario.UsuarioLogin);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Id", _usuario.Id);
                cmd.Parameters.AddWithValue("@IdProfissional", _usuario.IdProfissional);
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
        public void RemoverGrupoUsuario(int _idUsuario, int _idGrupoUsuario)//Givas
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            Usuario usuario = new Usuario();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"DELETE FROM  UsuarioGrupoUsuario 
                                    WHERE Id_Usuario = @Id_Usuario 
                                    AND Id_GrupoUsuario = @Id_GrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id_Usuario", _idUsuario);
                cmd.Parameters.AddWithValue("@Id_GrupoUsuario", _idGrupoUsuario);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um grupo: " + ex.Message);
            }
            finally
            {
                cn.Close();
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
        public Profissional BuscarPorCPF(string _cPF)//verficar as ligações com INNER JOIN
        {
            Profissional profissional = new Profissional();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Usuario.Id, Usuario.IdProfissional FROM Profissional 
                                        INNER JOIN Usuario ON Profissional.Id = Usuario.IdProfissional 
                                    WHERE Profissional.CPF LIKE @CPF";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CPF", _cPF);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        profissional.Id = Convert.ToInt32(rd["Id"]);
                        profissional.Nome = rd["Nome"].ToString();
                        profissional.CPF = rd["CPF"].ToString();
                        profissional.Logradouro = rd["Logradouro"].ToString();
                        profissional.Numero = rd["Numero"].ToString();
                        profissional.Bairro = rd["Bairro"].ToString();
                        profissional.Cidade = rd["Cidade"].ToString();
                        profissional.UF = rd["UF"].ToString();
                        profissional.Pais = rd["Pais"].ToString();
                        profissional.CEP = rd["CEP"].ToString();
                        profissional.DataNascimento = (DateTime)rd["DataNascimento"];

                        if (!String.IsNullOrEmpty(rd["Foto"].ToString()))
                            profissional.Foto = (byte[])rd["Foto"];

                        profissional.Ativo = (bool)rd["Ativo"];

                    }
                }

                return profissional;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar usuario no banco de dados.", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }
        }//Givas
        public List<Usuario> BuscarPorNome(string _nome)
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, IdProfissional, UsuarioLogin, Senha, Ativo FROM Usuario 
                                            WHERE UsuarioLogin LIKE @UsuarioLogin";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@UsuarioLogin", "%" + _nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.IdProfissional = Convert.ToInt32(rd["IdProfissional"]);
                        usuario.UsuarioLogin = rd["UsuarioLogin"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuario.GrupoUsuarios = new GrupoUsuarioDAL().BuscarPorIdUsuario(usuario.Id);
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar nome de usuário do banco de dados", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }
        }//Givas
        public void BuscarEmailProfissional(int _id)
        {
            EmailProfissional emailProfissional = new EmailProfissional();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, IdProfissional, Email FROM EmailProfissional WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        emailProfissional.Id = Convert.ToInt32(rd["Id"]);
                        emailProfissional.IdProfissional = Convert.ToInt32(rd["IdProfissional"]);
                        emailProfissional.Email = rd["Email"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar E-mail do Profissional no banco de dados", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }
        }//Givas
        public void BuscarPorFuncao(string _nome)
        {
            Funcao funcao = new Funcao();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome FROM Funcao WHERE Nome = @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _nome);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        funcao.Id = Convert.ToInt32(rd["Id"]);
                        funcao.Nome = rd["Nome"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um Nome na Funcao do Profissional no banco de dados", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }
        }//Givas
    }
}
