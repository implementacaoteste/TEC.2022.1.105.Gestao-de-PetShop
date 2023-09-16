using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AgendamentoDAL
    {
        public void Inserir(Agendamento _agendamento, SqlTransaction _transaction = null)
        {

            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Agendamento(IdAnimal, IdProfissional, IdSituacao, DataAg, Horario, Total, Ativo)VALUES(@IdAnimal, @IdProfissional, @IdSituacao, @DataAg, @Horario, @Total,@Ativo) SELECT @@IDENTITY", cn))
                {
                    cmd.Parameters.AddWithValue("@IdAnimal", Convert.ToInt32(_agendamento.IdAnimal));
                    cmd.Parameters.AddWithValue("@IdProfissional", Convert.ToInt32(_agendamento.IdProfissional));
                    cmd.Parameters.AddWithValue("@IdSituacao", Convert.ToInt32(_agendamento.IdSituacao));
                    cmd.Parameters.AddWithValue("@DataAg", _agendamento.DataAg); //Convert.ToDateTime
                    cmd.Parameters.AddWithValue("@Horario", _agendamento.Horario);
                    cmd.Parameters.AddWithValue("@Total", Convert.ToDecimal(_agendamento.Total));
                    cmd.Parameters.AddWithValue("@Ativo", _agendamento.Ativo);

                    if (_transaction == null)
                    {
                        cn.Open();
                        transaction = cn.BeginTransaction();
                    }

                    cmd.Transaction = transaction;
                    cmd.Connection = transaction.Connection;
                    try
                    {
                        int idagendamento = Convert.ToInt32(cmd.ExecuteScalar());
                        InserirAgendamentoServico(_agendamento, idagendamento, transaction);

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
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

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO AgendamentoServicos (IdAgendamento,IdServico, Quantidade, ValorUnitario)
                                                                                 VALUES (@IdAgendamento,@IdServico, @Quantidade,@ValorUnitario)", cn))
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

                        foreach (AgendamentoServico item in _agendamento.AgendamentoServicos)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@IdAgendamento", _idagendamento);
                            cmd.Parameters.AddWithValue("@IdServico", item.IdServico);
                            cmd.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                            cmd.Parameters.AddWithValue("@ValorUnitario", item.ValorUnitario);

                            cmd.ExecuteNonQuery();
                        }

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir todas as permissões do grupo no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
        public void Alterar(Agendamento _agendamento, List<AgendamentoServico> _servicosParaExcluir, SqlTransaction _transaction = null) //
        {
            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"UPDATE Agendamento SET IdAnimal = @IdAnimal,
                                                                                IdProfissional = @IdProfissional,
                                                                                IdSituacao = @IdSituacao,
                                                                                DataAg = @DataAg,
                                                                                Horario = @Horario,
                                                                                Total = @Total,
                                                                                Ativo = @Ativo
                                                                                WHERE Id = @Id", cn))
                {
                    cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(_agendamento.Id));
                    cmd.Parameters.AddWithValue("@IdAnimal", Convert.ToInt32(_agendamento.IdAnimal));
                    cmd.Parameters.AddWithValue("@IdProfissional", Convert.ToInt32(_agendamento.IdProfissional));
                    cmd.Parameters.AddWithValue("@IdSituacao", Convert.ToInt32(_agendamento.IdSituacao));
                    cmd.Parameters.AddWithValue("@DataAg", _agendamento.DataAg); //Convert.ToDateTime
                    cmd.Parameters.AddWithValue("@Horario", _agendamento.Horario);
                    cmd.Parameters.AddWithValue("@Total", Convert.ToDecimal(_agendamento.Total));
                    cmd.Parameters.AddWithValue("@Ativo", _agendamento.Ativo);
                    if (_transaction == null)
                    {
                        cn.Open();
                        transaction = cn.BeginTransaction();
                    }
                    cmd.Transaction = transaction;
                    cmd.Connection = transaction.Connection;
                    try
                    {
                        cmd.ExecuteNonQuery();

                        if (_servicosParaExcluir.Count > 0)
                        {
                            AlterarExcluirServicoDeAgendamento(_agendamento, _servicosParaExcluir, transaction);
                        }
                        if (_agendamento.AgendamentoServicos.Count > 0)
                        {
                            AlterarInserirAgendamentoServico(_agendamento, transaction);
                        }
                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar alterar um cadastro no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
        private void AlterarInserirAgendamentoServico(Agendamento _agendamento, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;
            List<AgendamentoServico> agendamentoservico = new List<AgendamentoServico>();
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO AgendamentoServicos (IdAgendamento,IdServico, Quantidade, ValorUnitario)
                                                                                 VALUES (@IdAgendamento,@IdServico, @Quantidade,@ValorUnitario)", cn))
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

                        foreach (AgendamentoServico item in _agendamento.AgendamentoServicos)
                        {

                            bool x = ExisteVinculo(_agendamento.Id, item.IdServico, transaction);
                            if (!x)
                            {
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@IdAgendamento", _agendamento.Id);
                                cmd.Parameters.AddWithValue("@IdServico", item.IdServico);
                                cmd.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                                cmd.Parameters.AddWithValue("@ValorUnitario", item.ValorUnitario);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar Alterar Serviços de um agendamnto no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
        public bool ExisteVinculo(int _idAgendamento, int _idServico, SqlTransaction _transaction)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 AS retorno FROM AgendamentoServicos  WHERE  IdAgendamento = @IdAgendamento AND IdServico = @IdServico";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdAgendamento", _idAgendamento);
                cmd.Parameters.AddWithValue("@IdServico", _idServico);

                cmd.Transaction = _transaction;
                cmd.Connection = _transaction.Connection;

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
                throw new Exception("Ocorreu um erro ao tentar buscar vínculos de Serviços com Agendamento: " + ex.Message) { Data = { { "Id", 45 } } };
            }
        }
        private void AlterarExcluirServicoDeAgendamento(Agendamento _agendamento, List<AgendamentoServico> _servicosParaExcluir, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM AgendamentoServicos WHERE Id = @Id", cn))
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

                        cmd.CommandType = System.Data.CommandType.Text;
                        foreach (AgendamentoServico item in _servicosParaExcluir)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@Id", item.Id);
                            cmd.ExecuteNonQuery();
                        }
                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir Serviços de um agendamento no banco de dados.", ex) { Data = { { "Id", 32 } } };
                    }
                }
            }
        }
        public void Excluir(Agendamento _agendamento, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"DELETE FROM Agendamento WHERE Id = @Id", cn))
                {
                    cmd.Parameters.AddWithValue("@Id", _agendamento.Id);
                    if (_transaction == null)
                    {
                        cn.Open();
                        transaction = cn.BeginTransaction();
                    }
                    cmd.Transaction = transaction;
                    cmd.Connection = transaction.Connection;
                    try
                    {
                        if (_agendamento.AgendamentoServicos.Count > 0)
                        {
                            AlterarExcluirServicoDeAgendamento(_agendamento, _agendamento.AgendamentoServicos, transaction);
                        }
                        cmd.ExecuteNonQuery();
                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir agendamento no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }

        public List<Agendamento> BuscarTodos(int _opcSituacao, int _opcAtivo)
        {
            List<Agendamento> agendamentos = new List<Agendamento>();
            Agendamento agendamento = new Agendamento();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.Id, Ag.DataAg,Ag.Horario,Ag.Total, Ag.Ativo,
                                           Ani.Id as AnimalId, Ani.Nome as NomeAnimal,
                                           Cli.Id as ClienteId, Cli.Nome as NomeCliente,
                                           P.Id as ProfissionalId, P.Nome as NomeProfissional,
                                           Si.Id as SituacaoId, Si.Descricao as DescSituacao
                                           FROM Agendamento Ag LEFT JOIN Profissional P     ON Ag.IdProfissional = P.Id
                                                               LEFT JOIN Animal Ani         ON Ag.IdAnimal = Ani.Id
                                                               LEFT JOIN Cliente Cli        ON Ani.IdCliente = Cli.Id
                                                               LEFT JOIN Situacao Si        ON Ag.IdSituacao = Si.Id ";

                if (_opcAtivo == 1)
                {
                    cmd.CommandText = cmd.CommandText + " WHERE Ag.Ativo = 1";
                }
                else if (_opcAtivo == 2)
                {
                    cmd.CommandText = cmd.CommandText + " WHERE Ag.Ativo = 0";
                }

                if (_opcSituacao == 1)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText + " WHERE UPPER(Si.Descricao) LIKE UPPER('Agendado')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Agendado')";
                    }
                }
                else if (_opcSituacao == 2)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText + " WHERE UPPER(Si.Descricao) LIKE UPPER('Em Andamento')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Em Andamento')";
                    }
                }
                else if(_opcSituacao == 3)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText + " WHERE UPPER(Si.Descricao) LIKE UPPER('Finalizado')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Finalizado')";
                    }
                }

                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        agendamento = new Agendamento();
                        agendamento.Id = Convert.ToInt32(rd["Id"]);
                        agendamento.DataAg = Convert.ToDateTime(rd["DataAg"]);
                        agendamento.IdAnimal = Convert.ToInt32(rd["AnimalId"]);
                        agendamento.NomeAnimal = rd["NomeAnimal"].ToString();
                        agendamento.IdCliente = Convert.ToInt32(rd["ClienteId"]);
                        agendamento.NomeCliente = rd["NomeCliente"].ToString();
                        agendamento.IdProfissional = Convert.ToInt32(rd["ProfissionalId"]);
                        agendamento.NomeProfissional = rd["NomeProfissional"].ToString();
                        agendamento.Horario = rd["Horario"].ToString();
                        agendamento.IdSituacao = Convert.ToInt32(rd["SituacaoId"]);
                        agendamento.DescricaoSituacao = rd["DescSituacao"].ToString();
                        agendamento.Total = Convert.ToDecimal(rd["Total"]);
                        agendamento.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        agendamento.AgendamentoServicos = new AgendamentoDAL().BuscarAgendamentoServicosPorIdAgendamento(agendamento.Id);

                        agendamentos.Add(agendamento);
                    }
                }
                return agendamentos;
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
        public Agendamento BuscarAgendamentoPorId(int _idAgendamento, int _opc)
        {
            List<Agendamento> agendamentos = new List<Agendamento>();
            Agendamento agendamento = new Agendamento();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.Id, Ag.DataAg,Ag.Horario,Ag.Total,Ag.Ativo, Ani.Id as AnimalId, Ani.Nome as NomeAnimal,Cli.Id as ClienteId, Cli.Nome as NomeCliente, P.Id as ProfissionalId, P.Nome as NomeProfissional,Si.Id as SituacaoId,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
                                                                                                                                                                                            LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                                            LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                                            LEFT JOIN Situacao Si                ON Ag.IdSituacao = Si.Id
                                                                                                                                                                                            WHERE ";

                if (_opc == 0)
                    cmd.CommandText = cmd.CommandText + "Ag.Id = @Id"; // Busca pelo ID do Agendamento
                else if (_opc == 1)
                    cmd.CommandText = cmd.CommandText + "Ani.Id = @Id";//Busca pelo ID do Animal
                else if (_opc == 2)
                    cmd.CommandText = cmd.CommandText + "Cli.Id = @Id"; // bUSCAR POR ID DO CLIENTE
                else if (_opc == 3)
                    cmd.CommandText = cmd.CommandText + "P.Id = @Id"; // buscar por Id do Profissional
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _idAgendamento);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        agendamento.Id = Convert.ToInt32(rd["Id"]);
                        agendamento.DataAg = Convert.ToDateTime(rd["DataAg"]);
                        agendamento.IdAnimal = Convert.ToInt32(rd["AnimalId"]);
                        agendamento.NomeAnimal = rd["NomeAnimal"].ToString();
                        agendamento.IdCliente = Convert.ToInt32(rd["ClienteId"]);
                        agendamento.NomeCliente = rd["NomeCliente"].ToString();
                        agendamento.IdProfissional = Convert.ToInt32(rd["ProfissionalId"]);
                        agendamento.NomeProfissional = rd["NomeProfissional"].ToString();
                        agendamento.Horario = rd["Horario"].ToString();
                        agendamento.IdSituacao = Convert.ToInt32(rd["SituacaoId"]);
                        agendamento.DescricaoSituacao = rd["DescSituacao"].ToString();
                        agendamento.Total = Convert.ToDecimal(rd["Total"]);
                        agendamento.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        agendamento.AgendamentoServicos = new AgendamentoDAL().BuscarAgendamentoServicosPorIdAgendamento(_idAgendamento);
                    }
                }
                return agendamento;
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
        public List<Agendamento> BuscarAgendamentoPorData(int _opc, string _data, int _opcAtivo = 0,int _opcSituacao = 0)
        {
            List<Agendamento> agendamentos = new List<Agendamento>();
            Agendamento agendamento;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.Id, Ag.DataAg,Ag.Horario,Ag.Total,Ag.Ativo, Ani.Id as AnimalId, Ani.Nome as NomeAnimal,Cli.Id as ClienteId, Cli.Nome as NomeCliente, P.Id as ProfissionalId, P.Nome as NomeProfissional,Si.Id as SituacaoId,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
                                                                                                                                                                                            LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                                            LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                                            LEFT JOIN Situacao Si                ON Ag.IdSituacao = Si.Id  ";
                if (_opc == 4)
                    cmd.CommandText = cmd.CommandText + " WHERE Ag.DataAg = @Data";
                else if (_opc == 5)
                    cmd.CommandText = cmd.CommandText + " WHERE YEAR(Ag.DataAg) = YEAR(@Data) and MONTH(Ag.DataAg) = MONTH(@Data)";
                else if (_opc == 6)
                    cmd.CommandText = cmd.CommandText + " WHERE YEAR(Ag.DataAg) = YEAR(@Data)";

                if (_opcAtivo == 1)
                {
                    cmd.CommandText = cmd.CommandText + " AND Ag.Ativo = 1";
                }
                else if (_opcAtivo == 2)
                {
                    cmd.CommandText = cmd.CommandText + " AND Ag.Ativo = 0";
                }

                if (_opcSituacao == 1)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Agendado')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Agendado')";
                    }
                }
                else if (_opcSituacao == 2)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Em Andamento')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Em Andamento')";
                    }
                }
                else if (_opcSituacao == 3)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Finalizado')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Finalizado')";
                    }
                }
                

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(_data));
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        agendamento = new Agendamento();
                        agendamento.Id = Convert.ToInt32(rd["Id"]);
                        agendamento.DataAg = Convert.ToDateTime(rd["DataAg"]);
                        agendamento.IdAnimal = Convert.ToInt32(rd["AnimalId"]);
                        agendamento.NomeAnimal = rd["NomeAnimal"].ToString();
                        agendamento.IdCliente = Convert.ToInt32(rd["ClienteId"]);
                        agendamento.NomeCliente = rd["NomeCliente"].ToString();
                        agendamento.IdProfissional = Convert.ToInt32(rd["ProfissionalId"]);
                        agendamento.NomeProfissional = rd["NomeProfissional"].ToString();
                        agendamento.Horario = rd["Horario"].ToString();
                        agendamento.IdSituacao = Convert.ToInt32(rd["SituacaoId"]);
                        agendamento.DescricaoSituacao = rd["DescSituacao"].ToString();
                        agendamento.Total = Convert.ToDecimal(rd["Total"]);
                        agendamento.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        agendamento.AgendamentoServicos = new AgendamentoDAL().BuscarAgendamentoServicosPorIdAgendamento(agendamento.Id);

                        agendamentos.Add(agendamento);
                    }
                }
                return agendamentos;
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
        public List<Agendamento> BuscarAgendamentoPorNomeCliente(string _nomeCliente,int _opcAtivo,int _opcSituacao)
        {
            List<Agendamento> agendamentos = new List<Agendamento>();
            Agendamento agendamento = new Agendamento();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.Id, Ag.DataAg,Ag.Horario,Ag.Total,Ag.Ativo, Ani.Id as AnimalId, Ani.Nome as NomeAnimal,Cli.Id as ClienteId, Cli.Nome as NomeCliente, P.Id as ProfissionalId, P.Nome as NomeProfissional,Si.Id as SituacaoId,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
                                                                                                                                                                                            LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                                            LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                                            LEFT JOIN Situacao Si                ON Ag.IdSituacao = Si.Id WHERE  UPPER(Cli.Nome) LIKE UPPER(@Nome)";//WHERE Ag.Id = @Id
                if (_opcAtivo == 1)
                {
                    cmd.CommandText = cmd.CommandText + " AND Ag.Ativo = 1";
                }
                else if (_opcAtivo == 2)
                {
                    cmd.CommandText = cmd.CommandText + " AND Ag.Ativo = 0";
                }

                if (_opcSituacao == 1)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Agendado')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Agendado')";
                    }

                }
                else if (_opcSituacao == 2)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Em Andamento')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Em Andamento')";
                    }
                }
                else if (_opcSituacao == 3)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Finalizado')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Finalizado')";
                    }
                }


                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nomeCliente + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        agendamento = new Agendamento();
                        agendamento.Id = Convert.ToInt32(rd["Id"]);
                        agendamento.DataAg = Convert.ToDateTime(rd["DataAg"]);
                        agendamento.IdAnimal = Convert.ToInt32(rd["AnimalId"]);
                        agendamento.NomeAnimal = rd["NomeAnimal"].ToString();
                        agendamento.IdCliente = Convert.ToInt32(rd["ClienteId"]);
                        agendamento.NomeCliente = rd["NomeCliente"].ToString();
                        agendamento.IdProfissional = Convert.ToInt32(rd["ProfissionalId"]);
                        agendamento.NomeProfissional = rd["NomeProfissional"].ToString();
                        agendamento.Horario = rd["Horario"].ToString();
                        agendamento.IdSituacao = Convert.ToInt32(rd["SituacaoId"]);
                        agendamento.DescricaoSituacao = rd["DescSituacao"].ToString();
                        agendamento.Total = Convert.ToDecimal(rd["Total"]);
                        agendamento.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        agendamento.AgendamentoServicos = new AgendamentoDAL().BuscarAgendamentoServicosPorIdAgendamento(agendamento.Id);

                        agendamentos.Add(agendamento);
                    }
                }
                return agendamentos;
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
        public List<Agendamento> BuscarAgendamentoPorNomeProfissional(string _nomeProfissional,int _opcAtivo, int _opcSituacao)
        {
            List<Agendamento> agendamentos = new List<Agendamento>();
            Agendamento agendamento = new Agendamento();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.Id, Ag.DataAg,Ag.Horario,Ag.Total,Ag.Ativo, Ani.Id as AnimalId, Ani.Nome as NomeAnimal,Cli.Id as ClienteId, Cli.Nome as NomeCliente, P.Id as ProfissionalId, P.Nome as NomeProfissional,Si.Id as SituacaoId,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
                                                                                                                                                                                            LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                                            LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                                            LEFT JOIN Situacao Si                ON Ag.IdSituacao = Si.Id WHERE  UPPER(P.Nome) LIKE UPPER(@Nome)";//WHERE Ag.Id = @Id

                if (_opcAtivo == 1)
                {
                    cmd.CommandText = cmd.CommandText + " AND Ag.Ativo = 1";
                }
                else if (_opcAtivo == 2)
                {
                    cmd.CommandText = cmd.CommandText + " AND Ag.Ativo = 0";
                }

                if (_opcSituacao == 1)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Agendado')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Agendado')";
                    }

                }
                else if (_opcSituacao == 2)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Em Andamento')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Em Andamento')";
                    }
                }
                else if (_opcSituacao == 3)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Finalizado')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Finalizado')";
                    }
                }

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nomeProfissional + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        agendamento = new Agendamento();
                        agendamento.Id = Convert.ToInt32(rd["Id"]);
                        agendamento.DataAg = Convert.ToDateTime(rd["DataAg"]);
                        agendamento.IdAnimal = Convert.ToInt32(rd["AnimalId"]);
                        agendamento.NomeAnimal = rd["NomeAnimal"].ToString();
                        agendamento.IdCliente = Convert.ToInt32(rd["ClienteId"]);
                        agendamento.NomeCliente = rd["NomeCliente"].ToString();
                        agendamento.IdProfissional = Convert.ToInt32(rd["ProfissionalId"]);
                        agendamento.NomeProfissional = rd["NomeProfissional"].ToString();
                        agendamento.Horario = rd["Horario"].ToString();
                        agendamento.IdSituacao = Convert.ToInt32(rd["SituacaoId"]);
                        agendamento.DescricaoSituacao = rd["DescSituacao"].ToString();
                        agendamento.Total = Convert.ToDecimal(rd["Total"]);
                        agendamento.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        agendamento.AgendamentoServicos = new AgendamentoDAL().BuscarAgendamentoServicosPorIdAgendamento(agendamento.Id);

                        agendamentos.Add(agendamento);
                    }
                }
                return agendamentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os Agendamentos do Profissional no banco de dados.", ex) { Data = { { "Id", 136 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Agendamento> BuscarAgendamentoPorProfissionalData(string _nomeProfissional, string _data, int _opc, int _opcAtivo, int _opcSituacao)
        {
            List<Agendamento> agendamentos = new List<Agendamento>();
            Agendamento agendamento;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.Id, Ag.DataAg,Ag.Horario,Ag.Total,Ag.Ativo, Ani.Id as AnimalId, Ani.Nome as NomeAnimal,Cli.Id as ClienteId, Cli.Nome as NomeCliente, P.Id as ProfissionalId, P.Nome as NomeProfissional,Si.Id as SituacaoId,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
                                                                                                                                                                                            LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                                            LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                                            LEFT JOIN AgendamentoServicos AgSe   ON Ag.Id = AgSe.IdAgendamento
                                                                                                                                                                                            LEFT JOIN Servico Se                 ON AgSe.IdServico = Se.Id
                                                                                                                                                                                            LEFT JOIN Situacao Si                ON Ag.IdSituacao = Si.Id WHERE   UPPER (P.Nome) LIKE UPPER (@NomeProfissional) ";

                if (_opc == 1)
                    cmd.CommandText = cmd.CommandText + " AND Ag.DataAg = @Data";
                else if (_opc == 2)
                    cmd.CommandText = cmd.CommandText + " AND YEAR(Ag.DataAg) = YEAR(@Data) and MONTH(Ag.DataAg) = MONTH(@Data)";
                else if (_opc == 3)
                    cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND YEAR(Ag.DataAg) = YEAR(@Data)";

                if (_opcAtivo == 1)
                {
                    cmd.CommandText = cmd.CommandText + " AND Ag.Ativo = 1";
                }
                else if (_opcAtivo == 2)
                {
                    cmd.CommandText = cmd.CommandText + " AND Ag.Ativo = 0";
                }

                if (_opcSituacao == 1)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Agendado')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Agendado')";
                    }
                }
                else if (_opcSituacao == 2)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Em Andamento')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Em Andamento')";
                    }
                }
                else if (_opcSituacao == 3)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Finalizado')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Finalizado')";
                    }
                }
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(_data));
                cmd.Parameters.AddWithValue("@NomeProfissional", "%" + _nomeProfissional + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    int id = 0;
                    int id2 = 0;
                    while (rd.Read())
                    {
                        id2 = Convert.ToInt32(rd["Id"]);
                        agendamento = new Agendamento();
                        if (id != id2)
                        {

                            agendamento.Id = Convert.ToInt32(rd["Id"]);
                            agendamento.DataAg = Convert.ToDateTime(rd["DataAg"]);
                            agendamento.IdAnimal = Convert.ToInt32(rd["AnimalId"]);
                            agendamento.NomeAnimal = rd["NomeAnimal"].ToString();
                            agendamento.IdCliente = Convert.ToInt32(rd["ClienteId"]);
                            agendamento.NomeCliente = rd["NomeCliente"].ToString();
                            agendamento.IdProfissional = Convert.ToInt32(rd["ProfissionalId"]);
                            agendamento.NomeProfissional = rd["NomeProfissional"].ToString();
                            agendamento.Horario = rd["Horario"].ToString();
                            agendamento.IdSituacao = Convert.ToInt32(rd["SituacaoId"]);
                            agendamento.DescricaoSituacao = rd["DescSituacao"].ToString();
                            agendamento.Total = Convert.ToDecimal(rd["Total"]);
                            agendamento.Ativo = Convert.ToBoolean(rd["Ativo"]);
                            agendamento.AgendamentoServicos = new AgendamentoDAL().BuscarAgendamentoServicosPorIdAgendamento(agendamento.Id);

                            agendamentos.Add(agendamento);
                            id = agendamento.Id;
                        }
                    }
                }
                return agendamentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Agendamento por Profissional e Data (Dia/Mês/Ano) no banco de dados.", ex) { Data = { { "Id", 137 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Agendamento> BuscarAgendamentoPorServico(string _nomeServico, int _opcAtivo, int _opcSituacao)
        {
            List<Agendamento> agendamentos = new List<Agendamento>();
            Agendamento agendamento;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT  Ag.Id, Ag.DataAg, Ag.Horario, Ag.Total,
                                            Ani.Id as AnimalId, Ani.Nome as NomeAnimal, 
                                            Cli.Id as ClienteId, Cli.Nome as NomeCliente,
                                            P.Id as ProfissionalId, P.Nome as NomeProfissional,
                                            Si.Id as SituacaoId, Si.Descricao as DescSituacao
                                            FROM Agendamento Ag
                                    LEFT JOIN Profissional P            ON Ag.IdProfissional = P.Id
                                    LEFT JOIN Animal Ani                ON Ag.IdAnimal = Ani.Id
                                    LEFT JOIN Cliente Cli               ON Ani.IdCliente = Cli.Id
                                    LEFT JOIN AgendamentoServicos AgSe  ON Ag.Id = AgSe.IdAgendamento
                                    LEFT JOIN Servico Se                ON AgSe.IdServico = Se.Id
                                    LEFT JOIN Situacao Si               ON Ag.IdSituacao = Si.Id 
                                    WHERE UPPER (Se.Descricao) LIKE UPPER (@NomeServico)";

                if (_opcAtivo == 1)
                {
                    cmd.CommandText = cmd.CommandText + " AND Ag.Ativo = 1";
                }
                else if (_opcAtivo == 2)
                {
                    cmd.CommandText = cmd.CommandText + " AND Ag.Ativo = 0";
                }

                if (_opcSituacao == 1)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Agendado')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Agendado')";
                    }
                }
                else if (_opcSituacao == 2)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Em Andamento')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Em Andamento')";
                    }
                }
                else if (_opcSituacao == 3)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Finalizado')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Finalizado')";
                    }
                }
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeServico", "%" + _nomeServico + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    int id = 0;
                    int id2 = 0;
                    while (rd.Read())
                    {
                        id2 = Convert.ToInt32(rd["Id"]);
                        if (id != id2)
                        {
                            agendamento = new Agendamento();
                            agendamento.Id = Convert.ToInt32(rd["Id"]);
                            agendamento.DataAg = Convert.ToDateTime(rd["DataAg"]);
                            agendamento.IdAnimal = Convert.ToInt32(rd["AnimalId"]);
                            agendamento.NomeAnimal = rd["NomeAnimal"].ToString();
                            agendamento.IdCliente = Convert.ToInt32(rd["ClienteId"]);
                            agendamento.NomeCliente = rd["NomeCliente"].ToString();
                            agendamento.IdProfissional = Convert.ToInt32(rd["ProfissionalId"]);
                            agendamento.NomeProfissional = rd["NomeProfissional"].ToString();
                            agendamento.Horario = rd["Horario"].ToString();
                            agendamento.IdSituacao = Convert.ToInt32(rd["SituacaoId"]);
                            agendamento.DescricaoSituacao = rd["DescSituacao"].ToString();
                            agendamento.Total = Convert.ToDecimal(rd["Total"]);
                            agendamento.AgendamentoServicos = new AgendamentoDAL().BuscarAgendamentoServicosPorIdAgendamento(agendamento.Id);

                            agendamentos.Add(agendamento);
                            id = agendamento.Id;
                        }
                    }
                }
                return agendamentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Agendamento por Serviço no banco de dados.", ex) { Data = { { "Id", 138 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Agendamento> BuscarAgendamentoPorServicoData( string _nomeServico, string _data, int _opc, int _opcAtivo, int _opcSituacao)
        {
            List<Agendamento> agendamentos = new List<Agendamento>();
            Agendamento agendamento;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.Id, Ag.DataAg,Ag.Horario,Ag.Total,Ag.Ativo, Ani.Id as AnimalId, Ani.Nome as NomeAnimal,Cli.Id as ClienteId, Cli.Nome as NomeCliente, P.Id as ProfissionalId, P.Nome as NomeProfissional,Si.Id as SituacaoId,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
                                                                                                                                                                                            LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                                            LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                                            LEFT JOIN AgendamentoServicos AgSe   ON Ag.Id = AgSe.IdAgendamento
                                                                                                                                                                                            LEFT JOIN Servico Se                 ON AgSe.IdServico = Se.Id
                                                                                                                                                                                            LEFT JOIN Situacao Si                ON Ag.IdSituacao = Si.Id WHERE UPPER (Se.Descricao) LIKE UPPER (@NomeServico) ";

                if (_opc == 1)
                    cmd.CommandText = cmd.CommandText + " AND Ag.DataAg = @Data";
                else if (_opc == 2)
                    cmd.CommandText = cmd.CommandText + " AND YEAR(Ag.DataAg) = YEAR(@Data) and MONTH(Ag.DataAg) = MONTH(@Data)";
                else if (_opc == 3)
                    cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND YEAR(Ag.DataAg) = YEAR(@Data)";

                if (_opcAtivo == 1)
                {
                    cmd.CommandText = cmd.CommandText + " AND Ag.Ativo = 1";
                }
                else if (_opcAtivo == 2)
                {
                    cmd.CommandText = cmd.CommandText + " AND Ag.Ativo = 0";
                }

                if (_opcSituacao == 1)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Agendado')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Agendado')";
                    }
                }
                else if (_opcSituacao == 2)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Em Andamento')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Em Andamento')";
                    }
                }
                else if (_opcSituacao == 3)
                {
                    if (_opcAtivo == 0)
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Finalizado')";
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = cmd.CommandText = cmd.CommandText + " AND UPPER(Si.Descricao) LIKE UPPER('Finalizado')";
                    }
                }

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Data", Convert.ToDateTime(_data));
                cmd.Parameters.AddWithValue("@NomeServico", "%" + _nomeServico + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    int id = 0;
                    int id2 = 0;
                    while (rd.Read())
                    {
                        id2 = Convert.ToInt32(rd["Id"]);
                        agendamento = new Agendamento();
                        if (id != id2)
                        {

                            agendamento.Id = Convert.ToInt32(rd["Id"]);
                            agendamento.DataAg = Convert.ToDateTime(rd["DataAg"]);
                            agendamento.IdAnimal = Convert.ToInt32(rd["AnimalId"]);
                            agendamento.NomeAnimal = rd["NomeAnimal"].ToString();
                            agendamento.IdCliente = Convert.ToInt32(rd["ClienteId"]);
                            agendamento.NomeCliente = rd["NomeCliente"].ToString();
                            agendamento.IdProfissional = Convert.ToInt32(rd["ProfissionalId"]);
                            agendamento.NomeProfissional = rd["NomeProfissional"].ToString();
                            agendamento.Horario = rd["Horario"].ToString();
                            agendamento.IdSituacao = Convert.ToInt32(rd["SituacaoId"]);
                            agendamento.DescricaoSituacao = rd["DescSituacao"].ToString();
                            agendamento.Total = Convert.ToDecimal(rd["Total"]);
                            agendamento.Ativo = Convert.ToBoolean(rd["Ativo"]);
                            agendamento.AgendamentoServicos = new AgendamentoDAL().BuscarAgendamentoServicosPorIdAgendamento(agendamento.Id);

                            agendamentos.Add(agendamento);
                            id = agendamento.Id;
                        }
                    }
                }
                return agendamentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Agendamento por Servico com Dia/Mês/Ano no banco de dados.", ex) { Data = { { "Id", 137 } } };
            }
            finally
            {
                cn.Close();
            }
        }
       

        private List<AgendamentoServico> BuscarAgendamentoServicosPorIdAgendamento(int _idAgendamento)
        {
            List<AgendamentoServico> servicos = new List<AgendamentoServico>();
            AgendamentoServico servico;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT AgeSer.Id,AgeSer.idServico, Ser.Descricao, AgeSer.ValorUnitario, AgeSer.Quantidade, Ser.Preco, Ser.Tempo 
                                    FROM AgendamentoServicos AgeSer INNER JOIN Servico Ser ON AgeSer.IdServico = Ser.Id  WHERE AgeSer.IdAgendamento = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _idAgendamento);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        servico = new AgendamentoServico();
                        servico.Id = Convert.ToInt32(rd["Id"]);
                        servico.IdServico = Convert.ToInt32(rd["IdServico"]);
                        servico.Servico = rd["Descricao"].ToString();
                        servico.ValorUnitario = Convert.ToDecimal(rd["ValorUnitario"]);
                        servico.Quantidade = Convert.ToInt32(rd["Quantidade"]);
                        servico.ValorUnitario = Convert.ToDecimal(rd["Preco"]);
                        servico.Tempo = Convert.ToInt32(rd["Tempo"]);
                        servico.Subtotal = servico.ValorUnitario * servico.Quantidade;

                        servicos.Add(servico);
                    }
                }
                return servicos;
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


        public Cliente BuscarPorIdAnimalCliente(int _id, int _opc)
        {
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT C.Id , C.Nome , A.Id   FROM Cliente C INNER JOIN Animal A  ON C.Id = A.IdCliente WHERE Ativo = 1 AND ";
                if (_opc == 0)
                {
                    cmd.CommandText = cmd.CommandText + "A.Id = @id";
                }
                if (_opc == 1)
                {
                    cmd.CommandText = cmd.CommandText + "C.Id = @id";
                }
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        cliente.Id = Convert.ToInt32(rd["Id"]);

                        cliente.Nome = rd["Nome"].ToString();
                        cliente.Animais = new AgendamentoDAL().BuscarAnimalPorIdCliente(cliente.Id);

                    }
                }
                return cliente;
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
        public List<Cliente> BuscarPorNomeAnimalCliente(string _nomeAnimalCliente, int _opc)
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente cliente;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT C.Id , C.Nome , A.Id   FROM Cliente C INNER JOIN Animal A  ON C.Id = A.IdCliente ";

                if (_opc == 2)
                {
                    cmd.CommandText = @"SELECT C.Id , C.Nome   FROM Cliente C LEFT JOIN Animal A ON A.IdCliente = C.Id  WHERE UPPER(A.Nome) LIKE UPPER(@Nome) AND C.Ativo = 1 AND A.Ativo = 1";
                }
                if (_opc == 3)
                {
                    cmd.CommandText = @"SELECT Id , Nome   FROM Cliente  WHERE UPPER (Nome) LIKE UPPER (@Nome) AND Ativo = 1";
                }
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nomeAnimalCliente + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    int id = 0;
                    int id2 = 0; // não extrai
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        id2 = Convert.ToInt32(rd["Id"]);
                        if (id != id2)
                        {

                            cliente.Id = Convert.ToInt32(rd["Id"]);
                            cliente.Nome = rd["Nome"].ToString();
                            cliente.Animais = new AgendamentoDAL().BuscarAnimalPorIdCliente(cliente.Id);
                            clientes.Add(cliente);
                            id = Convert.ToInt32(rd["Id"]);
                        }
                    }
                }
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Cliente no banco de dados.", ex) { Data = { { "Id", 46 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Profissional> BuscarPorNomeProfissional(string _nomeProfissional, int _idProfissional)
        {
            List<Profissional> profissionais = new List<Profissional>();
            Profissional profissional;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome FROM Profissional";
                if (_nomeProfissional != "" && _idProfissional == 0)
                {
                    cmd.CommandText = cmd.CommandText + "  WHERE UPPER (Nome) LIKE UPPER (@Nome)";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@Nome", "%" + _nomeProfissional + "%");
                }
                if (_nomeProfissional == "" && _idProfissional != 0)
                {
                    cmd.CommandText = cmd.CommandText + " WHERE Id = @Id";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@Id", _idProfissional);
                }
                if (_nomeProfissional == "" && _idProfissional == 0)
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                }
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        profissional = new Profissional();
                        profissional.Id = Convert.ToInt32(rd["Id"]);
                        profissional.Nome = rd["Nome"].ToString();
                        profissionais.Add(profissional);
                    }
                }
                return profissionais;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar Buscar Por Nome Profissinais no banco de dados.", ex) { Data = { { "Id", 46 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Profissional BuscarProfissional(string _nomeProfissional)
        {
            Profissional profissional = new Profissional();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome FROM Profissional   WHERE UPPER (Nome) LIKE UPPER (@Nome)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _nomeProfissional);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        profissional.Id = Convert.ToInt32(rd["Id"]);
                        profissional.Nome = rd["Nome"].ToString();
                    }
                }
                return profissional;
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
        public Situacao BuscarSituacaoPorNome(string _descricaoSituacao)
        {
            Situacao situacao = new Situacao();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Descricao FROM Situacao   WHERE UPPER (Descricao) LIKE UPPER (@Descricao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", _descricaoSituacao);
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
                throw new Exception("Ocorreu um erro ao tentar buscar todos os Serviços no banco de dados.", ex) { Data = { { "Id", 46 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        private List<Animal> BuscarAnimalPorIdCliente(int _idCliente)
        {
            List<Animal> animais = new List<Animal>();
            Animal animal;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome FROM Animal WHERE IdCliente = @Id AND Ativo = 1";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _idCliente);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        animal = new Animal();
                        animal.Id = Convert.ToInt32(rd["Id"]);
                        animal.Nome = rd["Nome"].ToString();
                        animais.Add(animal);
                    }
                }
                return animais;


            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar Animais por Id do Cliente no banco de dados.", ex) { Data = { { "Id", 34 } } };
            }
            finally
            {
                cn.Close();
            }


        }
       
    }
}
