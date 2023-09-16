using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class FuncaoDAL
    {
        public void Inserir(Funcao _funcao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Funcao(Nome) VALUES (@Nome)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _funcao.Nome);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir Função no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Funcao _funcao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"UPDATE Funcao SET
                                    Nome = @Nome
                                    WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _funcao.Id);
                cmd.Parameters.AddWithValue("@Nome", _funcao.Nome);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar função no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Funcao> BuscarTodos()
        {
            List<Funcao> funcaoList = new List<Funcao>();
            Funcao funcao = new Funcao();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = cn;

                cmd.CommandText = @"SELECT Id, Nome FROM Funcao";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        funcao = new Funcao();
                        funcao.Id = (int)rd["Id"];
                        funcao.Nome = rd["nome"].ToString();

                        funcao.Permissoes = new PermissaoDAL().BuscarPermissaoPorIdFuncao(funcao.Id);
                        funcaoList.Add(funcao);
                    }
                }
                return funcaoList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por todos no banco de dados.", ex) { Data = { { "Id", 17 } } };
            }
            finally
            {
                cn.Close();
            }

        }
        public Funcao BuscarPorId(int _id)
        {
            Funcao funcao = new Funcao();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome FROM Funcao WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        funcao.Id = (int)rd["Id"];
                        funcao.Nome = rd["Nome"].ToString();

                        funcao.Permissoes = new PermissaoDAL().BuscarPermissaoPorIdFuncao(funcao.Id);
                    }
                }
                return funcao;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por id no banco de dados", ex) { Data = { { "Id", 18 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Funcao> BuscarPorNome(String _nome)
        {
            List<Funcao> funcaoList = new List<Funcao>();
            Funcao funcao = new Funcao();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome FROM Funcao WHERE Nome Like @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        funcao = new Funcao();
                        funcao.Id = (int)rd["Id"];
                        funcao.Nome = rd["Nome"].ToString();

                        funcao.Permissoes = new PermissaoDAL().BuscarPermissaoPorIdFuncao(funcao.Id);
                        funcaoList.Add(funcao);
                    }
                }
                return funcaoList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar clientes por nome no banco de dados", ex) { Data = { { "Id", 19 } } };
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
                cmd.CommandText = @"DELETE FROM Funcao WHERE id = @id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma funcao do banco de dados.", ex) { Data = { { "Id", 100 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public void InserirPermissaoNaFuncao(int _idFuncao, int _idPermissao)
        {

                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"INSERT INTO FuncaoPermissao(IdFuncao,IdPermissao) VALUES (@IdFuncao, @IdPemrissao)";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdFuncao", _idFuncao);
                cmd.Parameters.AddWithValue("@IdPemrissao", _idPermissao);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível vincular a permissão na função no Banco de Dados.");
            }
            finally
            {
                cn.Close();
            }

        }

        public void RemoverPermissaoDeFuncao(int _idFuncao, int _idPermissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM FuncaoPermissao WHERE IdFuncao = @IdFuncao AND IdPermissao = @IdPermissao";

                cmd.CommandType= System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdFuncao", _idFuncao);
                cmd.Parameters.AddWithValue("@IdPermissao", _idPermissao);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery ();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentar Remover a permissão da função no Banco de Dados.");
            }
            finally 
            {
                cn.Close(); 
            }
        }

        public bool ExisteVinculaDeFuncaoComProfissional(int _idFuncao)
        {
            SqlConnection cn = new SqlConnection (Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand ();
                cmd.CommandText = @"SELECT 1 FROM Funcao INNER JOIN Profissional ON Funcao.Id = Profissional.IdFuncao 
                                    WHERE Funcao.Id = @IdFuncao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdFuncao", _idFuncao);

                cn.Open ();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                      return true;
                    }
                }
                return false;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao consultar vículo entre função e profissional no Banco de Dados.");
            }
            finally
            {
                cn.Close ();
            }
        }
    }
}
