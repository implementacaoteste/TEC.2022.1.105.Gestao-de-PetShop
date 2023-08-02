using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AnimalDAL
    {
        public void Inserir (Animal animal)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Animal(Nome, Sexo, Agressivo, Cor, Idade, Alergia, DataNascimento) 
                                               VALUES (@Nome, @Sexo, @Agresivo, @Cor, @Idade, Alergia, DataNascimento)";
                cmd.CommandType = System.Data.CommandType.Text;


                cmd.Parameters.AddWithValue("@Nome", animal.Nome);
                cmd.Parameters.AddWithValue("@Sexo", animal.Sexo);
                cmd.Parameters.AddWithValue("@Agressivo", animal.Agressivo);
                cmd.Parameters.AddWithValue("@Cor", animal.Cor);
                cmd.Parameters.AddWithValue("@Idade", animal.Idade);
                cmd.Parameters.AddWithValue("@Alergia", animal.Alergia);
                cmd.Parameters.AddWithValue("DataNascimento", animal.DataNascimento);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um Animal no banco de dados.", ex) { Data = { { "Id", 20 } } };
            }
            finally
            {
                cn.Close();
            }
        
        }
    }
}
