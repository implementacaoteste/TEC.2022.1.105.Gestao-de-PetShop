using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TelefoneProfissionalDAL
    {
        public void Inserir(TelefoneProfissional _telefoneProfissional, SqlTransaction _transaction = null)//Givas
        {
            SqlTransaction transaction = _transaction;
            List<Profissional> profissional = new List<Profissional>();

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO TelefoneProfissional (IdProfissional,Telefone)
                                                                              VALUES (@IdProfissional,@Telefone)", cn))
                {
                    try
                    {
                        if (transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.Parameters.AddWithValue("@IdProfissional", _telefoneProfissional.IdProfissional);
                        cmd.Parameters.AddWithValue("@Telefone", _telefoneProfissional.Telefone);


                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir um telefone no banco de dados.", ex) { Data = { { "Id", 800 } } };
                    }
                }
            }
        }
        public void Alterar(TelefoneProfissional _telefoneProfissional)//Givas
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE TelefoneProfissional SET Telefone = @Telefone WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _telefoneProfissional.IdProfissional);
                cmd.Parameters.AddWithValue("@Telefone", _telefoneProfissional.Telefone);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar Telefone do Profissional no Banco de Dados", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)//Givas
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM TelefoneProfissional WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("Id", _id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar Excluir um Telefone do Profissional no Banco de Dados", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<TelefoneProfissional> BuscarPorIdProfissional(int _idProfissional)//Givas
        {
            List<TelefoneProfissional> telefoneprofissionalList = new List<TelefoneProfissional>();
            TelefoneProfissional telefoneprofissional = new TelefoneProfissional();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, IdProfissional, Telefone FROM TelefoneProfissional WHERE IdProfissional LIKE @IdProfissional";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdProfissional", _idProfissional);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        telefoneprofissional = new TelefoneProfissional();
                        telefoneprofissional.Id = (int)rd["Id"];
                        telefoneprofissional.IdProfissional = (int)rd["IdProfissional"];
                        telefoneprofissional.Telefone = rd["Telefone"].ToString();

                        telefoneprofissionalList.Add(telefoneprofissional);
                    }
                }
                return telefoneprofissionalList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar Buscar Telefone do Profissional por Id no Banco de Dados", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<TelefoneProfissional> BuscarTelefoneProfissional(string _telefoneProfissional)//Givas
        {
            List<TelefoneProfissional> telefoneprofissionalList = new List<TelefoneProfissional>();
            TelefoneProfissional telefoneprofissional = new TelefoneProfissional();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id,IdProfissional, Telefone FROM TelefoneProfissional WHERE Telefone LIKE @Telefone";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Telefone", "%" + _telefoneProfissional + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        telefoneprofissional = new TelefoneProfissional();
                        telefoneprofissional.Id = (int)rd["Id"];
                        telefoneprofissional.IdProfissional = (int)rd["IdProfissional"];
                        telefoneprofissional.Telefone = rd["Telefone"].ToString();

                        telefoneprofissionalList.Add(telefoneprofissional);
                    }
                }
                return telefoneprofissionalList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Telefone Profissional no banco de dados", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        /* public void Alterar(TelefoneProfissional _telefoneProfissional)
         {
             SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
             try
             {
                 SqlCommand cmd = cn.CreateCommand();
                 cmd.CommandText = @"UPDATE Profissional SET 
                                             Telefone = @Telefone, 

                                         WHERE Id = @Id";
                 cmd.CommandType = System.Data.CommandType.Text;

                 cmd.Parameters.AddWithValue("@Id", _telefoneProfissional.Id);
                 cmd.Parameters.AddWithValue("@Telefone", _telefoneProfissional.Telefone);

                 cmd.Connection = cn;
                 cn.Open();

                 cmd.ExecuteNonQuery();
             }
             catch (Exception ex)
             {
                 throw new Exception("Erro ao tentar alterar telefone no banco de dados", ex) { Data = { { "Id", 801 } } };
             }
             finally
             {
                 cn.Close();
             }
         }*/
    }
}
