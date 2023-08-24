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
        private int _idagendamento = 0;

        public void Inserir(Agendamento _agendamento, SqlTransaction _transaction = null)
        {

            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Agendamento(IdAnimal, IdProfissional, IdSituacao, DataAg, Horario, Total, Ativo)VALUES(@IdAnimal, @IdProfissional, @IdSituacao, @DataAg, @Horario, @Total,@Ativo)", cn))
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
                        cmd.ExecuteNonQuery();

                        int idagendamento = BuscarIdDoAgendamento(_agendamento, transaction, _idagendamento);

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
            // agendamentoservico = _agendamento.AgendamentoServicos;

            //  int quantidadeservicos = agendamentoservico.Count;

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
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@IdAnimal", _agendamento.IdAnimal);
                        cmd.Parameters.AddWithValue("@IdProfissional", _agendamento.IdProfissional);
                        cmd.Parameters.AddWithValue("@IdSituacao", _agendamento.IdSituacao);
                        cmd.Parameters.AddWithValue("@DataAg", _agendamento.DataAg);
                        cmd.Parameters.AddWithValue("@Horario", _agendamento.Horario);
                        cmd.Parameters.AddWithValue("@Total", _agendamento.Total);

                        if (transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                _idagendamento = Convert.ToInt32(rd["Id"]);
                            }
                        }



                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir todos os usuários do grupo no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
            return _idagendamento;
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
                        throw new Exception("Ocorreu um erro ao tentar excluir todas as permissões do grupo no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }
        private void AlterarInserirAgendamentoServico(Agendamento _agendamento, SqlTransaction _transaction)
        {

            SqlTransaction transaction = _transaction;
            List<AgendamentoServico> agendamentoservico = new List<AgendamentoServico>();
            // agendamentoservico = _agendamento.AgendamentoServicos;



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

                            bool x = ExisteVinculo(_agendamento.Id, item.IdServico);
                            if (!x)
                            {
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@IdAgendamento", _agendamento.Id);
                                cmd.Parameters.AddWithValue("@IdServico", item.IdServico);
                                cmd.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                                cmd.Parameters.AddWithValue("@ValorUnitario", item.ValorComDesconto);

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
        public bool ExisteVinculo(int _idAgendamento, int _idServico)
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
                throw new Exception("Ocorreu um erro ao tentar buscar vínculos de Serviços com Agendamento: " + ex.Message) { Data = { { "Id", 45 } } };
            }

        }
        private void AlterarExcluirServicoDeAgendamento(Agendamento _agendamento, List<AgendamentoServico> _servicosParaExcluir, SqlTransaction _transaction)
        {



            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM AgendamentoServicos WHERE IdAgendamento = @IdAgendamento AND IdServico = @IdServico", cn))
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
                            cmd.Parameters.AddWithValue("@IdAgendamento", _agendamento.Id);
                            cmd.Parameters.AddWithValue("@IdServico", item.IdServico);
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
        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Agendamento WHERE Id = @Id", cn))
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
                        if (transaction != null && transaction.Connection != null)
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
                cmd.CommandText = @"SELECT Ag.Id,Ag.DataAg,Ag.Horario, Ani.Nome as N_Animal,Cli.Nome as N_Cliente, S.Descricao, P.Nome as N_Prof,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P                         ON Ag.IdProfissional = P.Id
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

                        agendamentosView.IdAgendamento = Convert.ToInt32(rd["Id"]);
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
        public Agendamento BuscarPorIdAnimalCliente(int _id, int _opc)
        {

            Agendamento agendamento = new Agendamento();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;


                cmd.CommandText = @"SELECT A.Id as AnimalId , A.Nome as AnimalNome ,C.Id as  ClienteId, C.Nome as ClienteNome 
                                        FROM Animal A INNER JOIN Cliente C  ON A.IdCliente = C.Id WHERE ";


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

                        agendamento.IdAnimal = Convert.ToInt32(rd["AnimalId"]);
                        agendamento.IdCliente = Convert.ToInt32(rd["ClienteId"]);
                        agendamento.NomeAnimal = rd["AnimalNome"].ToString();
                        agendamento.NomeCliente = rd["ClienteNome"].ToString();

                        //agendamento.IdProfissional = Convert.ToInt32(rd["IdProfissional"]);
                        //agendamento.IdSituacao = Convert.ToInt32(rd["IdSituacao"]);
                        //agendamento.DataAg = Convert.ToDateTime(rd["DataAg"]);
                        //agendamento.Horario = Convert.ToInt32(rd["Horario"]);
                        //agendamento.Total = Convert.ToInt32(rd["Total"]);
                        //agendamento.Ativo = Convert.ToBoolean(rd["Ativo"]);
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
        public List<Agendamento> BuscarPorNomeAnimalCliente(string _nomeAnimalCliente, int _opc)
        {
            List<Agendamento> listaAgendamentos = new List<Agendamento>();
            Agendamento agendamento;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT A.Id as AnimalId , A.Nome as AnimalNome ,C.Id as  ClienteId, C.Nome as ClienteNome 
                                        FROM Animal A INNER JOIN Cliente C  ON A.IdCliente = C.Id  ";


                if (_opc == 2)
                {
                    cmd.CommandText = cmd.CommandText + " WHERE UPPER (A.Nome) LIKE UPPER (@Nome)";

                }
                if (_opc == 3)
                {
                    cmd.CommandText = cmd.CommandText + "WHERE UPPER (C.Nome) LIKE UPPER (@Nome)";
                }
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nomeAnimalCliente + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        agendamento = new Agendamento();

                        agendamento.IdAnimal = Convert.ToInt32(rd["AnimalId"]);
                        agendamento.IdCliente = Convert.ToInt32(rd["ClienteId"]);
                        agendamento.NomeAnimal = rd["AnimalNome"].ToString();
                        agendamento.NomeCliente = rd["ClienteNome"].ToString();

                        listaAgendamentos.Add(agendamento);

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
        public List<AgendamentoServico> BuscarServicoPorNome(string _nomeServico)
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
                cmd.Parameters.AddWithValue("@Nome", _selectedText);
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
        public List<DataGridView1_FormsPrincipal> BuscarPorNomeProfissional(string _nomeProfissional)
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
                                                                                                                                                                                            WHERE UPPER(P.Nome) LIKE UPPER(@nomeProfissional)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nomeProfissional", "%" + _nomeProfissional + "%");
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
                throw new Exception("Ocorreu um erro ao tentar buscar todos os profissinais no banco de dados.", ex) { Data = { { "Id", 133 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<DataGridView1_FormsPrincipal> BuscarPorProfissionalDiaMesAno(string _diaMesAno)
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
                throw new Exception("Ocorreu um erro ao tentar buscar todos os Serviços no banco de dados.", ex) { Data = { { "Id", 134 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public object BuscarProfissionalPorMesAno(int _opc, string _mesAno)
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
                throw new Exception("Ocorreu um erro ao tentar buscar todos os Serviços no banco de dados.", ex) { Data = { { "Id", 135 } } };
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
                cmd.CommandText = @"SELECT Ag.Id, Ag.DataAg,Ag.Horario,Ag.Total, Ani.Id as AnimalId, Ani.Nome as NomeAnimal,Cli.Id as ClienteId, Cli.Nome as NomeCliente, P.Id as ProfissionalId, P.Nome as NomeProfissional,Si.Id as SituacaoId,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
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
                        agendamento.AgendamentoServicos = new AgendamentoDAL().BuscarAgendamentoServicosPorIdAgendamento(_idAgendamento);

                        //agendamentos.Add(agendamento);
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
        private List<AgendamentoServico> BuscarAgendamentoServicosPorIdAgendamento(int _idAgendamento)
        {

            List<AgendamentoServico> servicos = new List<AgendamentoServico>();
            AgendamentoServico servico;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT AgeSer.idServico, Ser.Descricao, AgeSer.ValorUnitario, AgeSer.Quantidade, Ser.Preco, Ser.Tempo 
                                    FROM AgendamentoServicos AgeSer INNER JOIN Servico Ser ON AgeSer.IdServico = Ser.Id  WHERE AgeSer.IdAgendamento = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _idAgendamento);
                cn.Open();


                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        servico = new AgendamentoServico();
                        servico.IdServico = Convert.ToInt32(rd["IdServico"]);
                        servico.Servico = rd["Descricao"].ToString();
                        servico.ValorComDesconto = Convert.ToDecimal(rd["ValorUnitario"]);
                        servico.Quantidade = Convert.ToInt32(rd["Quantidade"]);
                        servico.ValorUnitario = Convert.ToDecimal(rd["Preco"]);
                        servico.Tempo = Convert.ToInt32(rd["Tempo"]);
                        servico.ValorTotal = Convert.ToDecimal(Convert.ToInt32(rd["Quantidade"]) * Convert.ToDecimal(rd["ValorUnitario"]));



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
        public void ExcluirServicoDeAgendamento(int _idservico, int _idagendamento)
        {

            Agendamento agendamento = new Agendamento();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"DELETE FROM AgendamentoServicos WHERE IdServico = @IdServico AND IdAgendamento = @IdAgendamento ";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdServico", _idservico);
                cmd.Parameters.AddWithValue("@IdAgendamento", _idagendamento);
                cn.Open();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar Excluit Serviços de Agendamento no banco de dados.", ex) { Data = { { "Id", 46 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Agendamento> BuscarTodos()
        {
            List<Agendamento> agendamentos = new List<Agendamento>();
            Agendamento agendamento = new Agendamento();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.Id, Ag.DataAg,Ag.Horario,Ag.Total, Ani.Id as AnimalId, Ani.Nome as NomeAnimal,Cli.Id as ClienteId, Cli.Nome as NomeCliente, P.Id as ProfissionalId, P.Nome as NomeProfissional,Si.Id as SituacaoId,Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
                                                                                                                                                                                            LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                                            LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                                            LEFT JOIN Situacao Si                ON Ag.IdSituacao = Si.Id";//WHERE Ag.Id = @Id

                cmd.CommandType = System.Data.CommandType.Text;
                // cmd.Parameters.AddWithValue("@Id", _idAgendamento);
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

        public Animal BuscarPorIdAnimal(int _idpesquisa)
        {
            Animal animal = new Animal();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome , IdCliente FROM Animal WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _idpesquisa);
                cn.Open();


                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        animal.Id = Convert.ToInt32(rd["Id"]);
                        animal.Nome = rd["Nome"].ToString();
                        animal.IdCliente = Convert.ToInt32(rd["IdCliente"]);
                    }
                }
                return animal;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Animal no banco de dados.", ex) { Data = { { "Id", 46 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public Cliente BuscarPorIdCliente(int _idCliente)
        {
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome  FROM Cliente WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _idCliente);
                cn.Open();


                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        cliente.Id = Convert.ToInt32(rd["Id"]);
                        cliente.Nome = rd["Nome"].ToString();

                    }
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Animal no banco de dados.", ex) { Data = { { "Id", 46 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
