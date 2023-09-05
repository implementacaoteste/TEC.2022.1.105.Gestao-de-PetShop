using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmailProfissionalDAL
    {
        public void Inserir(EmailProfissional _emailProfissional, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            List<Profissional> profissional = new List<Profissional>();
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO EmailProfissional (IdProfissional, Email) VALUES (@IdProfissional, @Email)", cn))
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
                        cmd.Parameters.AddWithValue("@IdProfissional", _emailProfissional.IdProfissional);
                        cmd.Parameters.AddWithValue("@Email", _emailProfissional.Email);
                        cmd.ExecuteNonQuery();
                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                        {
                            transaction.Rollback();
                            throw new Exception("Ocorreu um erro ao tentar inserir um E-mail do profissional no banco de dados.", ex) { Data = { {"Id", -1 } } };
                        }
                    }
                }
            }
        }//Givas
        public void Alterar(EmailProfissional _emailProfissional, SqlTransaction _transaction = null)//Givas
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE EmailProfissional SET Email = @Email WHERE IdProfissional = @IdProfissional";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdProfissional", _emailProfissional.IdProfissional);
                cmd.Parameters.AddWithValue("@Email", _emailProfissional.Email);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar Email do Profissional no banco de dados", ex) { Data = { { "Id", -1 } } };
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
                cmd.CommandText = @"DELETE FROM EmailProfissional WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir E-mail do Profissional no banco de dados.", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }
        }//Givas
        public List<EmailProfissional> BuscarPorIdProfissional(int _idProfissional)//Givas
        {
            List<EmailProfissional> emailProfissionalList = new List<EmailProfissional>();
            EmailProfissional emailprofissional = new EmailProfissional();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, IdProfissional, Email FROM EmailProfissional WHERE IdProfissional = @IdProfissional";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdProfissional", _idProfissional);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        emailprofissional = new EmailProfissional();
                        emailprofissional.Id = (int)rd["Id"];
                        emailprofissional.IdProfissional = (int)rd["IdProfissional"];
                        emailprofissional.Email = rd["Email"].ToString();

                        emailProfissionalList.Add(emailprofissional);
                    }
                }
                return emailProfissionalList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Email do Profissional no banco de dados", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<EmailProfissional> BuscarEmailProfissional(string _emailProfissional)//Givas

        {
            List<EmailProfissional> emailProfissionalList = new List<EmailProfissional>();
            EmailProfissional emailprofissional = new EmailProfissional();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, IdProfissional, Email FROM EmailProfissional WHERE Email LIKE @Email";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Email", "%" + _emailProfissional + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        emailprofissional = new EmailProfissional();
                        emailprofissional.Id = (int)rd["Id"];
                        emailprofissional.IdProfissional = Convert.ToInt32(rd["Id"]);
                        emailprofissional.Email = rd["Email"].ToString();

                        emailProfissionalList.Add(emailprofissional);
                    }
                }
                return emailProfissionalList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar E-mail do Profissional no banco de dados", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }

        }
    }
}
