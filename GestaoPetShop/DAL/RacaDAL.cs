using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace DAL
{
    public class RacaDAL
    {
        public void Inserir(Raca _raca)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"ISERT INTO Raca(Nome, Especie, PaisOrigem)
                                             VOLUES(Nome, Especie, PaisOrigem)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _raca.Nome);
                cmd.Parameters.AddWithValue("@Especie", _raca.Especie);
                cmd.Parameters.AddWithValue("@PaisOrigem", _raca.PaisOrigem);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma raça no banco de dados.", ex) { Data = { { "Id", 28 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Raca _raca)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Raca SET Nome = @Nome, Especie = @Especie, PaisOrigem = @PaisOrigem)
                                   WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _raca.Id);
                cmd.Parameters.AddWithValue("@Nome", _raca.Nome);
                cmd.Parameters.AddWithValue("@Especie", _raca.Especie);
                cmd.Parameters.AddWithValue("@PaisOrigem", _raca.PaisOrigem);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar um raça no banco de dados.", ex) { Data = { { "Id", 29 } } }; ;
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Raca> BuscarTodos()
        {
            List<Raca> racas = new List<Raca>();
            Raca raca;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Especie, PaisOrigem FROM Raca";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        raca = new Raca();
                        raca.Id = Convert.ToInt32(rd["Id"]);
                        raca.Nome = rd["Nome"].ToString();
                        raca.Especie = rd["Especie"].ToString();
                        raca.PaisOrigem = rd["PaisOrigem"].ToString();

                        racas.Add(raca);
                    }
                }
                return racas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos as raça no banco de dados.", ex) { Data = { { "Id", 200 } } };
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
                cmd.CommandText = @"DELETE FROM Raca WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir raça no banco de dados.", ex) { Data = { { "Id", 201 } } };
            }
        }

    }
}
