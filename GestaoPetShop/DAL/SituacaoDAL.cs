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
    public class SituacaoDAL
    {
        public void Alterar(Situacao _situacao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Situacao SET Descricao = @Descricao WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _situacao.Id);
                cmd.Parameters.AddWithValue("@Descricao", _situacao.Descricao);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar uma Descrição no banco de dados.", ex) { Data = { { "Id", 39 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Situacao BuscarPorId(int _id)
        {
            Situacao situacao = new Situacao();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Descricao FROM Situacao WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        situacao.Id = Convert.ToInt32(rd["Id"]);
                        situacao.Descricao = rd["Descricao"].ToString();
                    }
                }
                return situacao;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar buscar uma situação por Id no banco de dados.", ex) { Data = { { "Id", 37 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Situacao> BuscarPorNome(string _nome)
        {
            List<Situacao> situacaos = new List<Situacao>();
            Situacao situacao;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Descricao FROM Situacao WHERE UPPER (Descricao) LIKE UPPER (@Descricao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", "%" + _nome + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        situacao = new Situacao();
                        situacao.Id = Convert.ToInt32(rd["Id"]);
                        situacao.Descricao = rd["Descricao"].ToString();

                        situacaos.Add(situacao);
                    }
                }
                return situacaos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar buscar todas as Descrições no banco de dados.", ex) { Data = { { "Id", 38 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Situacao> BuscarTodos()
        {
            List<Situacao> situacaos = new List<Situacao>();
            Situacao situacao;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Descricao FROM Situacao";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        situacao = new Situacao();
                        situacao.Id = Convert.ToInt32(rd["Id"]);
                        situacao.Descricao = rd["Descricao"].ToString();

                        situacaos.Add(situacao);
                    }
                }
                return situacaos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar buscar uma situação no banco de dados.", ex) { Data = { { "Id", 36 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Inserir(Situacao _situacao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Situacao(Descricao) VALUES (@Descricao)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", _situacao.Descricao);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma situação no banco de dados.", ex) { Data = { { "Id", 35 } } };
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
                cmd.CommandText = @"DELETE FROM Situacao WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar a uma Descrição no banco de dados.", ex) { Data = { { "Id", 130 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public bool ExisteVinculo(int _id)
        {

            Situacao situacao = new Situacao();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 AS retorno FROM Situacao  WHERE Id = @id ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar vínculos de Situação: " + ex.Message) { Data = { { "Id", 131 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}