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
    }
}
