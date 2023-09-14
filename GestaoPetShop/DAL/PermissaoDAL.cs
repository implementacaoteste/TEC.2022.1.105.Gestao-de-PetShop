using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class PermissaoDAL
    {
        public void Inserir(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO Permissao(Descricao) VALUES(@Descriao)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", _permissao.Descricao);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma permissão no banco de dados.", ex) { Data = { { "Id", 59 } } };
            }
            finally
            {
                cn.Close();
            }
        }//Givas
        public List<Permissao> BuscarTodos() /// OK não mexer
        {
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome FROM Permissao";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descricao = rd["Nome"].ToString();
                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as permissoes no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }//Givas
        public List<Permissao> BuscarPermissaoPorNome(string _nomePermissao)
        {
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome FROM Permissao WHERE UPPER(Nome) LIKE UPPER(@nomePermissao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nomePermissao", "%" + _nomePermissao + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descricao = rd["Nome"].ToString();
                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as permissões no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }//Givas
        public List<Permissao> BuscarPorId(int _id)//Givas  OK não mexer
        {
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome FROM Permissao WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descricao = rd["Nome"].ToString();
                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar permissoes por Id no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        internal List<Permissao> BuscarPermissaoPorIdFuncao(int _id)//Givas
        {
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Permissao.Id, Permissao.Nome FROM Permissao
                                    INNER JOIN FuncaoPermissao ON Permissao.Id = FuncaoPermissao.IdPermissao
                                    INNER JOIN Funcao ON FuncaoPermissao.IdFuncao = Funcao.Id
                                    WHERE Funcao.Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descricao = rd["Nome"].ToString();
                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar permissoes por Id no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Permissao _permissao)//Givas
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Permissao SET Descricao = @Descricao WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", _permissao.Descricao);
                cmd.Parameters.AddWithValue("@Descricao", _permissao.Id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar uma permissão no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "DELETE FROM Permissao WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir uma permissão no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }//Givas
    }
}