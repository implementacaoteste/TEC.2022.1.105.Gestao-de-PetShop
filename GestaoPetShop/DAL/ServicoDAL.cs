using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ServicoDAL
    {
        public void Inserir(Servico _servico )
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Servico(Descricao, Preco, Tempo,Ativo) 
                                    VALUES(@Descricao, @Preco, @Tempo,@Ativo)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", _servico.Descricao);
                cmd.Parameters.AddWithValue("@Preco",_servico.Preco);
                cmd.Parameters.AddWithValue("@Tempo", _servico.Tempo);
                cmd.Parameters.AddWithValue("@Ativo", _servico.Ativo);


                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um usuário no banco de dados.", ex) { Data = { { "Id", 40 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Servico> BuscarTodos()
        {
            List<Servico> servicos = new List<Servico>();
            Servico servico;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id,Descricao, Preco, Tempo, Ativo FROM Servico";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        servico = new Servico();
                        servico.Id = Convert.ToInt32(rd["Id"]);
                        servico.Descricao = rd["Descricao"].ToString();
                        servico.Preco = Convert.ToDecimal(rd["Preco"]);
                        servico.Tempo = Convert.ToInt32(rd["Tempo"]);
                        servico.Ativo = Convert.ToBoolean(rd["Ativo"]);

                        servicos.Add(servico);
                    }
                }
                return servicos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os Serviços no banco de dados.", ex) { Data = { { "Id", 41 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Servico BuscarPorId(int _id)
        {
            Servico servico = new Servico();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Descricao, Preco, Tempo, Ativo FROM Servico 
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        servico.Id = Convert.ToInt32(rd["Id"]);
                        servico.Descricao = rd["Descricao"].ToString();
                        servico.Preco = Convert.ToDecimal(rd["Preco"]);
                        servico.Tempo = Convert.ToInt32(rd["Tempo"]);
                        servico.Ativo = Convert.ToBoolean(rd["Ativo"]);
                    }
                }
                return servico;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuários no banco de dados.", ex) { Data = { { "Id", 42 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Servico> BuscarPorNome(string _nome)
        {
            List<Servico> servicos = new List<Servico>();
            Servico servico;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id,Descricao, Preco, Tempo, Ativo FROM Servico WHERE UPPER (Descricao) LIKE UPPER (@Descricao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", "%" + _nome + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        servico = new Servico();
                        servico.Id = Convert.ToInt32(rd["Id"]);
                        servico.Descricao = rd["Descricao"].ToString();
                        servico.Preco = Convert.ToDecimal(rd["Preco"]);
                        servico.Tempo = Convert.ToInt32(rd["Tempo"]);
                        servico.Ativo = Convert.ToBoolean(rd["Ativo"]);

                        servicos.Add(servico);
                    }
                }
                return servicos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os Serviços no banco de dados.", ex) { Data = { { "Id", 41 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Servico _servico)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Servico SET Descricao = @Descricao, Preco = @Preco, Tempo = @Tempo ,  Ativo = @Ativo
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _servico.Id);
                cmd.Parameters.AddWithValue("@Descricao", _servico.Descricao);
                cmd.Parameters.AddWithValue("@Preco", _servico.Preco);
                cmd.Parameters.AddWithValue("@Tempo", _servico.Tempo);
                cmd.Parameters.AddWithValue("@Ativo", _servico.Ativo);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar um usuário no banco de dados.", ex) { Data = { { "Id", 43 } } }; ;
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
                cmd.CommandText = @"DELETE FROM Servico WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id",_id);
                
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar excluir usuário no banco de dados.", ex) { Data = { { "Id", 44 } } };
                    
                
            }
        }
        public bool ExisteVinculo(int _id)
        {

            Servico servico = new Servico();
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 AS retorno FROM AgendamentoServicos  WHERE IdServico = @id ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);
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
            finally
            {
                cn.Close();
            }
        }

        public List<DataGridView1_FormsPrincipal> dataGridView(string _date)
        {
            List<DataGridView1_FormsPrincipal> listaAgendamentos = new List<DataGridView1_FormsPrincipal>();
            DataGridView1_FormsPrincipal agendamentosView;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Ag.DataAg,Ag.Horario, Ani.Nome as N_Animal,Cli.Nome as N_Cliente, S.Descricao, P.Nome as N_Prof, Si.Descricao as DescSituacao FROM Agendamento Ag LEFT JOIN Profissional P             ON Ag.IdProfissional = P.Id
                                                                                                                                                                           LEFT JOIN Animal Ani                 ON Ag.IdAnimal = Ani.Id
                                                                                                                                                                           LEFT JOIN Cliente Cli                ON Ani.IdCliente = Cli.Id
                                                                                                                                                                           LEFT JOIN Situacao Si                ON Ag.IdSituacao = Si.Id
                                                                                                                                                                           LEFT  JOIN AgendamentoServicos AGS   ON Ag.Id = AGS.IdAgendamento
                                                                                                                                                                           LEFT JOIN Servico S                  ON AGS.IdServico = S.Id 
                                                                                                                                                                           WHERE Ag.DataAg = @data";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@data", _date);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        agendamentosView = new DataGridView1_FormsPrincipal();
                        agendamentosView.DataAg = Convert.ToDateTime(rd["DataAg"]);
                        agendamentosView.NomeAnimal = rd["N_Animal"].ToString();
                        agendamentosView.NomeCliente = rd["N_Cliente"].ToString();
                        agendamentosView.Situacao = rd["DescSituacao"].ToString();
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
