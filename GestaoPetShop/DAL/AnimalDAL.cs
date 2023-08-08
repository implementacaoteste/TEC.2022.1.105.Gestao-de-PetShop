﻿using Models;
using RestSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AnimalDAL
    {
        public void Inserir(Animal _animal)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Animal(Id, IdCliente, Nome, Sexo, Agressivo, Cor, Idade, Alergia, DataNascimento, Ativo) 
                                               VALUES (@Id, @IdCliente, @Nome, @Sexo, @Agresivo, @Cor, @Idade, @Alergia, @DataNascimento, @Ativo)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _animal.Id);
                cmd.Parameters.AddWithValue("@IdCliente", _animal.IdCliente);
                cmd.Parameters.AddWithValue("@Nome", _animal.Nome);
                cmd.Parameters.AddWithValue("@Sexo", _animal.Sexo);
                cmd.Parameters.AddWithValue("@Agressivo", _animal.Agressivo);
                cmd.Parameters.AddWithValue("@Cor", _animal.Cor);
                cmd.Parameters.AddWithValue("@Idade", _animal.Idade);
                cmd.Parameters.AddWithValue("@Alergia", _animal.Alergia);
                cmd.Parameters.AddWithValue("@DataNascimento", _animal.DataNascimento);
                cmd.Parameters.AddWithValue("@Ativo", _animal.Ativo);

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

        public void Alterar(Animal _animal)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Animal(Id, IdCliente, Nome, Sexo, Agressivo, Cor, Idade, Alergia, DataNascimento, Ativo) 
                                               VALUES (@Id, @IdCliente, @Nome, @Sexo, @Agresivo, @Cor, @Idade, @Alergia, @DataNascimento, @Ativo)";

                cmd.CommandType = System.Data.CommandType.Text;


                cmd.Parameters.AddWithValue("@Id", _animal.Id);
                cmd.Parameters.AddWithValue("@IdCliente", _animal.IdCliente);
                cmd.Parameters.AddWithValue("@Nome", _animal.Nome);
                cmd.Parameters.AddWithValue("@Sexo", _animal.Sexo);
                cmd.Parameters.AddWithValue("@Agressivo", _animal.Agressivo);
                cmd.Parameters.AddWithValue("Cor", _animal.Cor);
                cmd.Parameters.AddWithValue("Idade", _animal.Idade);
                cmd.Parameters.AddWithValue("Alergia", _animal.Alergia);
                cmd.Parameters.AddWithValue("DataNascimento", _animal.DataNascimento);
                cmd.Parameters.AddWithValue("@Ativo", _animal.Ativo);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar Animal no banco de dados", ex) { Data = { { "Id", 21 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Animal> BuscarPorNome(string _nome)
        {
            List<Animal> animalList = new List<Animal>();
            Animal animal = new Animal();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, IdCliente, Nome, Sexo, Agressivo, Cor, Idade, Alergia, DataNascimento, Ativo FROM Animal WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        animal = new Animal();
                        animal.Id = (int)rd["Id"];
                        animal.Nome = rd["Nome"].ToString();
                        //animal.Sexo = rd["Sexo"].     validar 
                        //animal.Agressivo = rd["Agressivo"].     validar
                        animal.Cor = rd["Cor"].ToString();
                        animal.Idade = (int)rd["Idade"];
                        animal.Alergia = rd["Alergia"].ToString();
                        animal.DataNascimento = rd["DataNascimento"].ToString();
                        //animal.Ativo = (bool)rd["Ativo"];

                        animalList.Add(animal);
                    }
                }
                return animalList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar animal por nome no banco de dados", ex) { Data = { { "Id", 22 } } };
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
                cmd.CommandText = @"DELETE FROM Animal WHERE id = @id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir animal no banco de dados.", ex) { Data = { { "Id", 23 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Animal> BuscarTodos()
        {
            List<Animal> animalList = new List<Animal>();
            Animal animal = new Animal();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, IdCliente, Nome, Sexo, Agressivo, Cor, Idade, Alergia, DataNascimento, Ativo FROM Animal";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        animal = new Animal();
                        animal.Id = (int)rd["Id"];
                        animal.IdCliente = (int)rd["IdCliente"];
                        animal.Nome = rd["Nome"].ToString();
                        /* animal.Agressivo = rd["Agressivo"].*/
                        animal.Cor = rd["Cor"].ToString();
                        animal.Idade = (int)rd["Idade"];
                        animal.Alergia = rd["Alergia"].ToString();
                        animal.DataNascimento = rd["DataNascimento"].ToString();
                        animal.Ativo = (bool)rd["Ativo"];

                        animalList.Add(animal);
                    }
                }
                return animalList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar animal no banco de dados", ex) { Data = { { "Id", 24 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Animal BuscarPorId(int _id) //BuscarPorCodigo
        {
            Animal animal = new Animal();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = @"SELECT Id,Nome, Sexo, Agressivo, Cor, Alergia, DataNascimento ,Ativo FROM Cliente WHERE Id = @Id";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", _id);

            cn.Open();
            using (SqlDataReader rd = cmd.ExecuteReader())

                try
                {
                    while (rd.Read())
                    {
                        animal.Id = (int)rd["Id"];
                        animal.Nome = rd["Nome"].ToString();
                        //animal.Sexo = rd["Sexo"].ToString();
                        //animal.Agressivo = rd["Agressivo"].ToString();
                        animal.Cor = rd["Cor"].ToString();
                        animal.Alergia = rd["Alergia"].ToString();
                        animal.DataNascimento = rd["DataNascimento"].ToString();
                        animal.Ativo = (bool)rd["Ativo"];

                    }
                    return animal;
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar buscar animal por id no banco de dados", ex) { Data = { { "Id", 25 } } };
                }
                finally
                {
                    cn.Close();
                }
        }
        public List<Raca> BuscarPorRaca(string _raca)
        {
            List<Raca> animalList = new List<Raca>();
            Raca animal = new Raca();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Especie, PaisOrigem FROM Animal WHERE Nome LIKE @Raca";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Raca", "%" + _raca + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    animal = new Raca();
                    animal.Id = (int)rd["Id"];
                    animal.Nome= rd["Nome"].ToString();
                    animal.Especie = rd["Cor"].ToString();
                    animal.PaisOrigem = rd["Idade"].ToString();
                  
                    animalList.Add(animal);
                }
                return animalList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar animal por raça por nome no banco de dados", ex) { Data = { { "Id", 26 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Raca> BuscarPorEspecie(string _especie)
        {
            List<Raca> animalList = new List<Raca>();
            Raca animal = new Raca();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Especie, PaisOrigem FROM Animal WHERE Nome LIKE @Raca";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Raca", "%" + _especie + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    animal = new Raca();
                    animal.Id = (int)rd["Id"];
                    animal.Nome = rd["Nome"].ToString();
                    animal.Especie = rd["Cor"].ToString();
                    animal.PaisOrigem = rd["Idade"].ToString();

                    animalList.Add(animal);
                }
                return animalList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar animal por especie por nome no banco de dados", ex) { Data = { { "Id", 27 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
