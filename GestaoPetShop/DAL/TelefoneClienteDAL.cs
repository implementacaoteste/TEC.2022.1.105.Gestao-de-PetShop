using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TelefoneClienteDAL
    {
        public void Inserir(TelefoneCliente _telefoneCliente, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            List<Cliente> cliente = new List<Cliente>();

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO TelefoneCliente (IdCliente,Telefone)
                                                                              VALUES (@IdCliente,@Telefone)", cn))
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

                        cmd.Parameters.AddWithValue("@IdCliente", _telefoneCliente.IdCliente);
                        cmd.Parameters.AddWithValue("@Telefone", _telefoneCliente.Telefone);


                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir um telefone no banco de dados.", ex) { Data = { { "Id", 109 } } };
                    }
                }
            }
        }
        public void Alterar(TelefoneCliente _telefoneCliente)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Cliente SET 
                                        Telefone = @Telefone, 
                                        
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _telefoneCliente.Id);
                cmd.Parameters.AddWithValue("@Telefone", _telefoneCliente.Telefone);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar telefone no banco de dados", ex) { Data = { { "Id", 111 } } };
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
                cmd.CommandText = @"DELETE FROM TelefoneCliente WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir telefonecliente no banco de dados.", ex) { Data = { { "Id", 116 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<TelefoneCliente> BuscarPorIdCliente(int _idCliente)
        {
            List<TelefoneCliente> telefoneclienteList = new List<TelefoneCliente>();
            TelefoneCliente telefonecliente = new TelefoneCliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Telefone FROM TelefoneCliente WHERE IdCliente LIKE @IdCliente";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdCliente", _idCliente);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        telefonecliente = new TelefoneCliente();
                        telefonecliente.Id = (int)rd["Id"];
                        telefonecliente.Telefone = rd["Telefone"].ToString();

                        telefoneclienteList.Add(telefonecliente);
                    }
                }
                return telefoneclienteList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar TelefoneCliente no banco de dados", ex) { Data = { { "Id", 115 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<TelefoneCliente> BuscarTelefoneCliente(string _telefoneCliente)
        {
            List<TelefoneCliente> telefoneclienteList = new List<TelefoneCliente>();
            TelefoneCliente telefonecliente = new TelefoneCliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id,Telefone FROM TelefoneCliente WHERE Telefone LIKE @Telefone";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Telefone", "%" + _telefoneCliente + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        telefonecliente = new TelefoneCliente();
                        telefonecliente.Id = (int)rd["Id"];
                        telefonecliente.Telefone = rd["Telefone"].ToString();

                        telefoneclienteList.Add(telefonecliente);
                    }
                }
                return telefoneclienteList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar telefone Cliente no banco de dados", ex) { Data = { { "Id", 1 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
