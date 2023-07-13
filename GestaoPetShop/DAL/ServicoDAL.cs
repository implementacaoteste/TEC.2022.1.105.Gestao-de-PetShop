using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ServicoDAL
    {
        public void Inserir(Servico _servico )
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Servico(Descricao, Preco, Tempo,Ativo) 
                                    VALUES(@Descricao, @Preco, @Tempo,@Ativo)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", _servico.Descricao);
                cmd.Parameters.AddWithValue("@Preco",_servico.Preco);
                cmd.Parameters.AddWithValue("@Tempo", _servico.Tempo);
                cmd.Parameters.AddWithValue("@Ativo", _servico.Ativo);


                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um usuário no banco de dados.", ex) { Data = { { "Id", 40 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Servico> BuscarTodos()
        {
            List<Servico> servicos = new List<Servico>();
            Servico servico;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id,Descricao, Preco, Tempo, Ativo FROM Servico";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        servico = new Servico();
                        servico.Id = Convert.ToInt32(rd["Id"]);
                        servico.Descricao = rd["Descricao"].ToString();
                        servico.Preco = Convert.ToDecimal(rd["Preco"]);
                        servico.Tempo = Convert.ToInt32(rd["Tempo"]);
                        servico.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        servicos.Add(servico);
                    }
                }
                return servicos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os Serviços no banco de dados.", ex) { Data = { { "Id", 41 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Servico BuscarPorId(int _id)
        {
            Servico servico = new Servico();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Descrico,Preco, Tempo, Ativo FROM Servico 
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        servico.Id = Convert.ToInt32(rd["Id"]);
                        servico.Descricao = rd["Descricao"].ToString();
                        servico.Preco = Convert.ToDecimal(rd["Preco"]);
                        servico.Tempo = Convert.ToInt32(rd["Tempo"]);
                        servico.Ativo = Convert.ToBoolean(rd["Ativo"]);
                    }
                }
                return servico;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuários no banco de dados.", ex) { Data = { { "Id", 42 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Servico _servico)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Servico SET Descricao = @Descricao, Preco = @Preco, Tempo = @Tempo ,  Ativo = @Ativo
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _servico.Id);
                cmd.Parameters.AddWithValue("@Descricao", _servico.Descricao);
                cmd.Parameters.AddWithValue("@Preco", _servico.Preco);
                cmd.Parameters.AddWithValue("@Tempo", _servico.Tempo);
                cmd.Parameters.AddWithValue("@Ativo", _servico.Ativo);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar um usuário no banco de dados.", ex) { Data = { { "Id", 43 } } }; ;
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
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Servico WHERE Id = @Id", cn))
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
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir usuário no banco de dados.", ex) { Data = { { "Id", 44 } } };
                    }
                }
            }
        }
    }
}
