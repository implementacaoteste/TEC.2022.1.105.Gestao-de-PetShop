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
        public void Alterar(EmailProfissional _emailProfissional, SqlTransaction _transaction)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE EmailProfissional SET 
                                        Email = @Email, 
                                        
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _emailProfissional.Id);
                cmd.Parameters.AddWithValue("@Email", _emailProfissional.Email);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar Email profissional no banco de dados", ex) { Data = { { "Id", 810 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public void Inserir(EmailProfissional _emailProfissional, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            List<Profissional> profissional = new List<Profissional>();

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO EmailProfissional (IdProfissional,Email)
                                                                              VALUES (@IdProfissional,@Email)", cn))
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
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir um e-mail no banco de dados.", ex) { Data = { { "Id", 809 } } };
                    }
                }
            }
        }

    }
}
