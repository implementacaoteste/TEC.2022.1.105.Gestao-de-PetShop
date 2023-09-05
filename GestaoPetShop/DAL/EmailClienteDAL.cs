using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmailClienteDAL
    {
        public List<EmailCliente> BuscarEmailCliente(string _emailCliente)

        {
            List<EmailCliente> emailclienteList = new List<EmailCliente>();
            EmailCliente emailcliente = new EmailCliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Email FROM EmailCliente WHERE Email LIKE @Email";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Email", "%" + _emailCliente + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        emailcliente = new EmailCliente();
                        emailcliente.Id = (int)rd["Id"];
                        emailcliente.Email = rd["Email"].ToString();

                        emailclienteList.Add(emailcliente);
                    }
                }
                return emailclienteList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar E-mail Cliente no banco de dados", ex) { Data = { { "Id", 114 } } };
            }
            finally
            {
                cn.Close();
            }

        }
        public void Inserir(EmailCliente _emailCliente, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            List<Cliente> cliente = new List<Cliente>();

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO EmailCliente (IdCliente,Email)
                                                                                 VALUES (@IdCliente,@Email)", cn))
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

                        cmd.Parameters.AddWithValue("@IdCliente", _emailCliente.IdCliente);
                        cmd.Parameters.AddWithValue("@Email", _emailCliente.Email);

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir um e-mail no banco de dados.", ex) { Data = { { "Id", 107 } } };
                    }
                }
            }
        }
        public void Alterar(EmailCliente _emailCliente, SqlTransaction _transaction)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE EmailCliente SET 
                                        Email = @Email,                                         
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _emailCliente.Id);
                cmd.Parameters.AddWithValue("@Email", _emailCliente.Email);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar Email no banco de dados", ex) { Data = { { "Id", 110 } } };
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
                cmd.CommandText = @"DELETE FROM EmailCliente WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir e-mail cliente no banco de dados.", ex) { Data = { { "Id", 115 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<EmailCliente> BuscarPorIdCliente(int _idCliente)
        {
            List<EmailCliente> emailClienteList = new List<EmailCliente>();
            EmailCliente emailcliente = new EmailCliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Email FROM EmailCliente WHERE IdCliente = @IdCliente";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdCliente", _idCliente);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        emailcliente = new EmailCliente();
                        emailcliente.Id = (int)rd["Id"];
                        emailcliente.Email = rd["Email"].ToString();

                        emailClienteList.Add(emailcliente);
                    }
                }
                return emailClienteList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar EmailCliente no banco de dados", ex) { Data = { { "Id", 114 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
