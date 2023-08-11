using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AgendamentoDAL
    {
        private int _idagendamento;

        public void Inserir(Agendamento _agendamento, SqlTransaction _transaction = null)
        {

            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Agendamento(IdAnimal, IdProfissional, IdSituacao, DataAg, Horario, Total, Ativo)VALUES(@IdAnimal, @IdProfissional, @IdSituacao, @DataAg, @Horario, @Total,@Ativo)", cn))
                {
                    cmd.Parameters.AddWithValue("@IdAnimal", _agendamento.IdAnimal);
                    cmd.Parameters.AddWithValue("@IdProfissional", _agendamento.IdProfissional);
                    cmd.Parameters.AddWithValue("@IdSituacao", _agendamento.IdSituacao);
                    cmd.Parameters.AddWithValue("@DataAg", _agendamento.DataAg);
                    cmd.Parameters.AddWithValue("@Horario", _agendamento.Horario);
                    cmd.Parameters.AddWithValue("@Total", _agendamento.Total);
                    cmd.Parameters.AddWithValue("@Ativo", _agendamento.Ativo);

                    if (_transaction == null)
                    {
                        cn.Open();
                        transaction = cn.BeginTransaction();
                    }

                    cmd.Transaction = transaction;
                    cmd.Connection = transaction.Connection;

                    int idagendamento = BuscarIdDoAgendamento(_agendamento, transaction, _idagendamento);

                    InserirAgendamentoServico(_agendamento, _idagendamento, transaction);

                    try
                    {
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }

                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir todas as permissões do grupo no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }

        }

        private void InserirAgendamentoServico(Agendamento _agendamento, int _idagendamento, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;
            List<AgendamentoServico> agendamentoservico = new List<AgendamentoServico>();
            agendamentoservico = _agendamento.agendamentoServicos;
            int quantidadeservicos = agendamentoservico.Count;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INFO AgendamentoServico (IdAgendamento,IdServico, Quantidade, ValorUnitario)
                                                                                 VALUES (@IdAgendamento,@IdServico, @Quantidade,@ValorUnitario)", cn))
                {


                    for (int x = 0; x < quantidadeservicos; x++)
                    {
                        cmd.Parameters.AddWithValue("@IdAgendamento", _idagendamento);
                        cmd.Parameters.AddWithValue("@IdServico", agendamentoservico[x].IdServico);
                        cmd.Parameters.AddWithValue("@IdQuantidade", agendamentoservico[x].Quantidade);
                        cmd.Parameters.AddWithValue("@ValorUnitario", agendamentoservico[x].ValorUnitario);


                        if (transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }
                    }
                    cmd.Transaction = transaction;
                    cmd.Connection = transaction.Connection;

                    try
                    {
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir todas as permissões do grupo no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }

        private int BuscarIdDoAgendamento(Agendamento _agendamento, SqlTransaction _transaction, int _idagendamento)
        {

            SqlTransaction transaction = _transaction;


            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT Id FROM Agendamento WHERE IdAnimal = @IdAnimal AND IdProfissional = @IdProfissional 
                                                                                                               AND IdSituacao     = @IdSituacao
                                                                                                               AND DataAg         = @DataAg
                                                                                                               AND Horario        = @Horario
                                                                                                               AND Total          = @Total", cn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@IdAnimal", _agendamento.IdAnimal);
                    cmd.Parameters.AddWithValue("@IdProfissional", _agendamento.IdProfissional);
                    cmd.Parameters.AddWithValue("@IdSituacao", _agendamento.IdSituacao);
                    cmd.Parameters.AddWithValue("@DataAg", _agendamento.DataAg);
                    cmd.Parameters.AddWithValue("@Horario", _agendamento.Horario);
                    cmd.Parameters.AddWithValue("@Total", _agendamento.Total);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            _idagendamento = Convert.ToInt32(rd["Id"]);




                        }
                    }

                    if (transaction == null)
                    {
                        cn.Open();
                        transaction = cn.BeginTransaction();
                    }
                    cmd.Transaction = transaction;
                    cmd.Connection = transaction.Connection;

                    try
                    {
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();


                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir todos os usuários do grupo no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }


                }
            }

            return _idagendamento;

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
                cmd.CommandText = @"SELECT Ag.DataAg,Ag.Horario, Ani.Nome as N_Animal,Cli.Nome as N_Cliente, S.Descricao, P.Nome as N_Prof,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P                         ON Ag.IdProfissional = P.Id
                                                                                                                                                                           LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                           LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                           LEFT JOIN AgendamentoServicos AGS    ON Ag.Id = AGS.IdAgendamento
                                                                                                                                                                           LEFT JOIN Servico S                  ON AGS.IdServico = S.Id
                                                                                                                                                                           LEFT JOIN Situacao Si                ON Ag.IdSituacao = Si.Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        agendamentosView = new DataGridView1_FormsPrincipal();
                        agendamentosView.DataAg = Convert.ToDateTime(rd["DataAg"]);
                        agendamentosView.NomeAnimal = rd["N_Animal"].ToString();
                        agendamentosView.NomeCliente = rd["N_Cliente"].ToString();
                        agendamentosView.Servico = rd["Descricao"].ToString();
                        agendamentosView.Profissional = rd["N_Prof"].ToString();
                        agendamentosView.Horario = rd["Horario"].ToString();
                        agendamentosView.Situacao = rd["DescSituacao"].ToString();


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
        public Agendamento BuscarPorId(int _id, int opc)
        {
            /*
             *  try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
               
               

             */
            Agendamento agendamento = new Agendamento();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.DataAg,Ag.Horario, Ani.Nome as N_Animal,Cli.Nome as N_Cliente, S.Descricao, P.Nome as N_Prof,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
                                                                                                                                                                                            LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                                            LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                                            LEFT JOIN AgendamentoServicos AGS    ON Ag.Id = AGS.IdAgendamento
                                                                                                                                                                                            LEFT JOIN Servico S                  ON AGS.IdServico = S.Id
                                                                                                                                                                                            LEFT JOIN Situacao Si                ON Ag.IdSituacao = Si.Id
                                                                                                                                                                                            WHERE Ag.DataAg = @Data";

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
                        agendamento.DataAg = Convert.ToDateTime(rd["DataAg"]);
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

        public object BuscarPorNomeAnimal(string _nomeAnimal)
        {
            List<DataGridView1_FormsPrincipal> listaAgendamentos = new List<DataGridView1_FormsPrincipal>();
            DataGridView1_FormsPrincipal agendamentosView;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.DataAg,Ag.Horario, Ani.Nome as N_Animal,Cli.Nome as N_Cliente, S.Descricao, P.Nome as N_Prof,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
                                                                                                                                                                                            LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                                            LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                                            LEFT JOIN AgendamentoServicos AGS    ON Ag.Id = AGS.IdAgendamento
                                                                                                                                                                                            LEFT JOIN Servico S                  ON AGS.IdServico = S.Id
                                                                                                                                                                                            LEFT JOIN Situacao Si                ON Ag.IdSituacao = Si.Id
                                                                                                                                                                                            WHERE UPPER(Ani.Nome) LIKE UPPER(@nomeAnimal)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nomeAnimal", "%" + _nomeAnimal + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        agendamentosView = new DataGridView1_FormsPrincipal();
                        agendamentosView.DataAg = Convert.ToDateTime(rd["DataAg"]);
                        agendamentosView.NomeAnimal = rd["N_Animal"].ToString();
                        agendamentosView.NomeCliente = rd["N_Cliente"].ToString();
                        agendamentosView.Servico = rd["Descricao"].ToString();
                        agendamentosView.Profissional = rd["N_Prof"].ToString();
                        agendamentosView.Horario = rd["Horario"].ToString();
                        agendamentosView.Situacao = rd["DescSituacao"].ToString();


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


        public List<DataGridView1_FormsPrincipal> DataGridViewBuscarPorId(int _idAgendamento, int _opc)
        {
            List<DataGridView1_FormsPrincipal> listaAgendamentos = new List<DataGridView1_FormsPrincipal>();
            DataGridView1_FormsPrincipal agendamentosView;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.DataAg,Ag.Horario, Ani.Nome as N_Animal,Cli.Nome as N_Cliente, S.Descricao, P.Nome as N_Prof,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
                                                                                                                                                                                            LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                                            LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                                            LEFT JOIN AgendamentoServicos AGS    ON Ag.Id = AGS.IdAgendamento
                                                                                                                                                                                            LEFT JOIN Servico S                  ON AGS.IdServico = S.Id
                                                                                                                                                                                            LEFT JOIN Situacao Si                ON Ag.IdSituacao = Si.Id
                                                                                                                                                                                            WHERE ";
                if (_opc == 0)
                    cmd.CommandText = cmd.CommandText + "Ag.Id = @id"; // Busca pelo ID do Agendamento
                else if (_opc == 1)
                    cmd.CommandText = cmd.CommandText + "Ani.Id = @Id";//Busca pelo ID do Animal
                else if (_opc == 2)
                    cmd.CommandText = cmd.CommandText + "Cli.Id = @Id";//Busca pelo ID do CLiente
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _idAgendamento);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        agendamentosView = new DataGridView1_FormsPrincipal();
                        agendamentosView.DataAg = Convert.ToDateTime(rd["DataAg"]);
                        agendamentosView.NomeAnimal = rd["N_Animal"].ToString();
                        agendamentosView.NomeCliente = rd["N_Cliente"].ToString();
                        agendamentosView.Servico = rd["Descricao"].ToString();
                        agendamentosView.Profissional = rd["N_Prof"].ToString();
                        agendamentosView.Horario = rd["Horario"].ToString();
                        agendamentosView.Situacao = rd["DescSituacao"].ToString();


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

        public List<DataGridView1_FormsPrincipal> BuscarPorNomeCliente(string _nomeCliente)
        {
            List<DataGridView1_FormsPrincipal> listaAgendamentos = new List<DataGridView1_FormsPrincipal>();
            DataGridView1_FormsPrincipal agendamentosView;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.DataAg,Ag.Horario, Ani.Nome as N_Animal,Cli.Nome as N_Cliente, S.Descricao, P.Nome as N_Prof,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
                                                                                                                                                                                            LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                                            LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                                            LEFT JOIN AgendamentoServicos AGS    ON Ag.Id = AGS.IdAgendamento
                                                                                                                                                                                            LEFT JOIN Servico S                  ON AGS.IdServico = S.Id
                                                                                                                                                                                            LEFT JOIN Situacao Si                ON Ag.IdSituacao = Si.Id
                                                                                                                                                                                            WHERE UPPER(Cli.Nome) LIKE UPPER(@nomeCliente)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nomeCLiente", "%" + _nomeCliente + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        agendamentosView = new DataGridView1_FormsPrincipal();
                        agendamentosView.DataAg = Convert.ToDateTime(rd["DataAg"]);
                        agendamentosView.NomeAnimal = rd["N_Animal"].ToString();
                        agendamentosView.NomeCliente = rd["N_Cliente"].ToString();
                        agendamentosView.Servico = rd["Descricao"].ToString();
                        agendamentosView.Profissional = rd["N_Prof"].ToString();
                        agendamentosView.Horario = rd["Horario"].ToString();
                        agendamentosView.Situacao = rd["DescSituacao"].ToString();


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

        public List<DataGridView1_FormsPrincipal> BuscarPorDiaMesAno(string _diaMesAno)
        {

            List<DataGridView1_FormsPrincipal> listaAgendamentos = new List<DataGridView1_FormsPrincipal>();
            DataGridView1_FormsPrincipal agendamentosView;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.DataAg,Ag.Horario, Ani.Nome as N_Animal,Cli.Nome as N_Cliente, S.Descricao, P.Nome as N_Prof,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
                                                                                                                                                                                            LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                                            LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                                            LEFT JOIN AgendamentoServicos AGS    ON Ag.Id = AGS.IdAgendamento
                                                                                                                                                                                            LEFT JOIN Servico S                  ON AGS.IdServico = S.Id
                                                                                                                                                                                            LEFT JOIN Situacao Si                ON Ag.IdSituacao = Si.Id
                                                                                                                                                                                            WHERE Ag.DataAg = @Data";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(_diaMesAno));
                cn.Open();


                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        agendamentosView = new DataGridView1_FormsPrincipal();
                        agendamentosView.DataAg = Convert.ToDateTime(rd["DataAg"]);
                        agendamentosView.NomeAnimal = rd["N_Animal"].ToString();
                        agendamentosView.NomeCliente = rd["N_Cliente"].ToString();
                        agendamentosView.Servico = rd["Descricao"].ToString();
                        agendamentosView.Profissional = rd["N_Prof"].ToString();
                        agendamentosView.Horario = rd["Horario"].ToString();
                        agendamentosView.Situacao = rd["DescSituacao"].ToString();


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

        public object BuscarPorMesAno(int _opc, string _mesAno)
        {
            List<DataGridView1_FormsPrincipal> listaAgendamentos = new List<DataGridView1_FormsPrincipal>();
            DataGridView1_FormsPrincipal agendamentosView;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = @"SELECT Ag.DataAg,Ag.Horario, Ani.Nome as N_Animal,Cli.Nome as N_Cliente, S.Descricao, P.Nome as N_Prof,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
                                                                                                                                                                                            LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                                            LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                                            LEFT JOIN AgendamentoServicos AGS    ON Ag.Id = AGS.IdAgendamento
                                                                                                                                                                                            LEFT JOIN Servico S                  ON AGS.IdServico = S.Id
                                                                                                                                                                                            LEFT JOIN Situacao Si                ON Ag.IdSituacao = Si.Id
                                                                                                                                                                                            WHERE ";

                if (_opc == 5)
                    cmd.CommandText = cmd.CommandText + "YEAR(Ag.DataAg) = YEAR(@Data) and MONTH(Ag.DataAg) = MONTH(@Data)";
                else if (_opc == 6)
                    cmd.CommandText = cmd.CommandText = cmd.CommandText + "YEAR(Ag.DataAg) = YEAR(@Data)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(_mesAno));
                cn.Open();


                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        agendamentosView = new DataGridView1_FormsPrincipal();
                        agendamentosView.DataAg = Convert.ToDateTime(rd["DataAg"]);
                        agendamentosView.NomeAnimal = rd["N_Animal"].ToString();
                        agendamentosView.NomeCliente = rd["N_Cliente"].ToString();
                        agendamentosView.Servico = rd["Descricao"].ToString();
                        agendamentosView.Profissional = rd["N_Prof"].ToString();
                        agendamentosView.Horario = rd["Horario"].ToString();
                        agendamentosView.Situacao = rd["DescSituacao"].ToString();


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

        public List<AgendamentoServico> BuscarsServicoPorNome(string _nomeServico)
        {

            List<AgendamentoServico> listaServicos = new List<AgendamentoServico>();
            AgendamentoServico servicoView;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Descricao, Preco FROM Servico   WHERE UPPER (Descricao) LIKE UPPER (@Nome)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nomeServico + "%");
                cn.Open();


                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        servicoView = new AgendamentoServico();
                        servicoView.Id = Convert.ToInt32(rd["Id"]);
                        servicoView.Servico = rd["Descricao"].ToString();
                        servicoView.ValorUnitario = Convert.ToDecimal(rd["Preco"]);



                        listaServicos.Add(servicoView);
                    }
                }
                return listaServicos;
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

        public Servico PorNome(string _selectedText)
        {

            Servico servicoView;
            servicoView = new Servico();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Descricao, Preco FROM Servico   WHERE UPPER (Descricao) LIKE UPPER (@Nome)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _selectedText + "%");
                cn.Open();


                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {

                        servicoView.Id = Convert.ToInt32(rd["Id"]);
                        servicoView.Descricao = rd["Descricao"].ToString();
                        servicoView.Preco = Convert.ToDecimal(rd["Preco"]);




                    }
                }
                return servicoView;
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
        public List<DataGridView1_FormsPrincipal> BuscarPorProfissional(string _nomeProfissional)
        {
            List<DataGridView1_FormsPrincipal> listaprofissionais = new List<DataGridView1_FormsPrincipal>();
            DataGridView1_FormsPrincipal profissionaisView;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.DataAg,Ag.Horario, Ani.Nome as N_Animal,Cli.Nome as N_Cliente, S.Descricao, P.Nome as N_Prof,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
                                                                                                                                                                                            LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                                            LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                                            LEFT JOIN AgendamentoServicos AGS    ON Ag.Id = AGS.IdAgendamento
                                                                                                                                                                                            LEFT JOIN Servico S                  ON AGS.IdServico = S.Id
                                                                                                                                                                                            LEFT JOIN Situacao Si                ON Ag.IdSituacao = Si.Id
                                                                                                                                                                                            WHERE UPPER(P.Nome) LIKE UPPER(@NomeProfissional)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeProfissional", "%" + _nomeProfissional + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        profissionaisView = new DataGridView1_FormsPrincipal();
                        profissionaisView.DataAg = Convert.ToDateTime(rd["DataAg"]);
                        profissionaisView.NomeAnimal = rd["N_Animal"].ToString();
                        profissionaisView.NomeCliente = rd["N_Cliente"].ToString();
                        profissionaisView.Servico = rd["Descricao"].ToString();
                        profissionaisView.Profissional = rd["N_Prof"].ToString();
                        profissionaisView.Horario = rd["Horario"].ToString();
                        profissionaisView.Situacao = rd["DescSituacao"].ToString();


                        listaprofissionais.Add(profissionaisView);
                    }
                }
                return listaprofissionais;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os Profissionais no banco de dados.", ex) { Data = { { "Id", 132 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
