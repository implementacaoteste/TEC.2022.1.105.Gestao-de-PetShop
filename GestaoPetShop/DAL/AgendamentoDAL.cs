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
        public List<DataGridView1_FormsPrincipal> DataGridViewBuscarTodos()
        {
            
            List<DataGridView1_FormsPrincipal> listaAgendamentos = new List<DataGridView1_FormsPrincipal>();
            DataGridView1_FormsPrincipal agendamentosView;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.DataAg,Ag.Horario, Ani.Nome as N_Animal,Cli.Nome as N_Cliente, S.Descricao, P.Nome as N_Prof FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
                                                                                                                                                                           LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                           LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                           LEFT  JOIN AgendamentoServicos AGS   ON Ag.Id = AGS.IdAgendamento
                                                                                                                                                                           LEFT JOIN Servico S                  ON AGS.IdServico = S.Id";
                //  WHERE Ag.DataAg = @data"; TC.Telefone,LEFT JOIN TelefoneCliente TC         ON Cli.Id = TC.IdCliente
                cmd.CommandType = System.Data.CommandType.Text;
              //  cmd.Parameters.AddWithValue("@data", _date);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        agendamentosView = new DataGridView1_FormsPrincipal();
                        agendamentosView.DataAg = rd["DataAg"].ToString();
                        agendamentosView.NomeAnimal = rd["N_Animal"].ToString();
                        agendamentosView.NomeCliente = rd["N_Cliente"].ToString();
                        agendamentosView.TelCliente = rd["Telefone"].ToString();
                        agendamentosView.Servico = rd["Descricao"].ToString();
                        agendamentosView.Profissional = rd["N_Prof"].ToString();
                        agendamentosView.Horario = rd["Horario"].ToString();


                        listaAgendamentos.Add(agendamentosView);
                    }
                }
                return listaAgendamentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os Serviços no banco de dados.", ex) { Data = { { "Id", 46 } } };
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

        public object BuscarPorNomeAnimal(string nomeAnimal)
        {
            throw new NotImplementedException();
        }

        public List<DataGridView1_FormsPrincipal> DataGridViewBuscarPorId(int _idAgendamento)
        {
            List<DataGridView1_FormsPrincipal> listaAgendamentos = new List<DataGridView1_FormsPrincipal>();
            DataGridView1_FormsPrincipal agendamentosView;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.DataAg,Ag.Horario, Ani.Nome as N_Animal,Cli.Nome as N_Cliente, S.Descricao, P.Nome as N_Prof FROM Agendamento Ag LEFT JOIN Profissional P                         ON Ag.IdProfissional = P.Id
                                                                                                                                                                           LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                           LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                           LEFT  JOIN AgendamentoServicos AGS   ON Ag.Id = AGS.IdAgendamento
                                                                                                                                                                           LEFT JOIN Servico S                  ON AGS.IdServico = S.Id
                                                                                                                                                                           WHERE Ag.Id = @id";
                //  WHERE Ag.DataAg = @data";// TC.Telefone,LEFT JOIN TelefoneCliente TC         ON Cli.Id = TC.IdCliente
                cmd.CommandType = System.Data.CommandType.Text;
                 cmd.Parameters.AddWithValue("@id", _idAgendamento);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        agendamentosView = new DataGridView1_FormsPrincipal();
                        agendamentosView.DataAg = rd["DataAg"].ToString();
                        agendamentosView.NomeAnimal = rd["N_Animal"].ToString();
                        agendamentosView.NomeCliente = rd["N_Cliente"].ToString();
                      //  agendamentosView.TelCliente = rd["Telefone"].ToString();
                        agendamentosView.Servico = rd["Descricao"].ToString();
                        agendamentosView.Profissional = rd["N_Prof"].ToString();
                        agendamentosView.Horario = rd["Horario"].ToString();


                        listaAgendamentos.Add(agendamentosView);
                    }
                }
                return listaAgendamentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os Serviços no banco de dados.", ex) { Data = { { "Id", 46 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
