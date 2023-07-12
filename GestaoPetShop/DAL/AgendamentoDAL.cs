using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AgendamentoDAL
    {
        public void Inserir(Agendamento _agendamento)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Agendamento(IdAnimal, IdProfissional, IdSituacao, DataAg, Horario, Total, Ativo) 
                                    VALUES(@IdAnimal, @IdProfissional, @IdSituacao, @DataAg, @Horario, @Total,@Ativo)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdAnimal", _agendamento.IdAnimal);
                cmd.Parameters.AddWithValue("@IdProfissional", _agendamento.IdProfissional);
                cmd.Parameters.AddWithValue("@IdSituacao", _agendamento.IdSituacao);
                cmd.Parameters.AddWithValue("@DataAg", _agendamento.DataAg);
                cmd.Parameters.AddWithValue("@Horario", _agendamento.Horario);
                cmd.Parameters.AddWithValue("@Total", _agendamento.Total);
                cmd.Parameters.AddWithValue("@Ativo", _agendamento.Ativo);


                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um agendamento no banco de dados.", ex) { Data = { { "Id", 30 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Agendamento _agendamento)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Agendamento SET IdAnimal = @IdAnimal, IdProfissional = @IdProfissional, IdSituacao = @IdSituacao, DataAg = @DataAg, Horario = @Horario, Total = @Total, Ativo = @Ativo
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdAnimal", _agendamento.IdAnimal);
                cmd.Parameters.AddWithValue("@IdProfissional", _agendamento.IdProfissional);
                cmd.Parameters.AddWithValue("@IdSituacao", _agendamento.IdSituacao);
                cmd.Parameters.AddWithValue("@DataAg", _agendamento.DataAg);
                cmd.Parameters.AddWithValue("@Horario", _agendamento.Horario);
                cmd.Parameters.AddWithValue("@Total", _agendamento.Total);
                cmd.Parameters.AddWithValue("@Ativo", _agendamento.Ativo);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar um agendamento no banco de dados.", ex) { Data = { { "Id", 31 } } }; ;
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
                        throw new Exception("Ocorreu um erro ao tentar excluir um agendamento no banco de dados.", ex) { Data = { { "Id", 32 } } };
                    }
                }
            }
        }
        public List<Agendamento> BuscarTodos()
        {
            List<Agendamento> agendamentos = new List<Agendamento>();
            Agendamento agendamento;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdAnimal, IdProfissional, IdSituacao, DataAg, Horario, Total, Ativo FROM Agendamento";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        agendamento = new Agendamento();
                        agendamento.Id = Convert.ToInt32(rd["Id"]);
                        agendamento.IdAnimal = Convert.ToInt32(rd["IdAnimal"]);
                        agendamento.IdProfissional = Convert.ToInt32(rd["IdProfissional"]);
                        agendamento.IdSituacao = Convert.ToInt32(rd["IdSituacao"]);
                        agendamento.DataAg = Convert.ToInt32(rd["DataAg"]);
                        agendamento.Horario = Convert.ToInt32(rd["Horario"]);
                        agendamento.Total = Convert.ToInt32(rd["Total"]);
                        agendamento.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        agendamentos.Add(agendamento);
                    }
                }
                return agendamentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os Agendamentos no banco de dados.", ex) { Data = { { "Id", 33 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Agendamento BuscarPorId(int _id)
        {
            Agendamento agendamento = new Agendamento();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, IdAnimal, IdProfissional, IdSituacao, DataAg, Horario, Total, Ativo FROM Agendamento 
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        agendamento.Id = Convert.ToInt32(rd["Id"]);
                        agendamento.IdAnimal = Convert.ToInt32(rd["IdAnimal"]);
                        agendamento.IdProfissional = Convert.ToInt32(rd["IdProfissional"]);
                        agendamento.IdSituacao = Convert.ToInt32(rd["IdSituacao"]);
                        agendamento.DataAg = Convert.ToInt32(rd["DataAg"]);
                        agendamento.Horario = Convert.ToInt32(rd["Horario"]);
                        agendamento.Total = Convert.ToInt32(rd["Total"]);
                        agendamento.Ativo = Convert.ToBoolean(rd["Ativo"]);
                    }
                }
                return agendamento;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar os agendamento por Id no banco de dados.", ex) { Data = { { "Id", 34 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
