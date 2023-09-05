using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class ProfissionalDAL
    {
        private int _idprofissional = 0;
        public void Alterar(Profissional _profissional)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Profissional SET 
                                        Idfuncao = @Idfuncao
                                        Nome = @Nome, 
                                        CPF = @CPF, 
                                        Logradouro = @Logradouro, 
                                        Numero = @Numero, 
                                        Bairro = @Bairro,
                                        Cidade = @Cidade,
                                        UF= @UF,
                                        Pais = @Pais,
                                        CEP = @CEP,
                                        DataNascimento = @DataNascimento,   
                                        Foto = @Foto,            
                                        Ativo = @Ativo
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Idfuncao", _profissional.IdFuncao);
                cmd.Parameters.AddWithValue("@Id", _profissional.Id);
                cmd.Parameters.AddWithValue("@Nome", _profissional.Nome);
                cmd.Parameters.AddWithValue("@CPF", _profissional.CPF);
                cmd.Parameters.AddWithValue("@Logradouro", _profissional.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", _profissional.Numero);
                cmd.Parameters.AddWithValue("@Bairro", _profissional.Bairro);
                cmd.Parameters.AddWithValue("@Cidade", _profissional.Cidade);
                cmd.Parameters.AddWithValue("@UF", _profissional.UF);
                cmd.Parameters.AddWithValue("@Pais", _profissional.Pais);
                cmd.Parameters.AddWithValue("@CEP", _profissional.CEP);
                cmd.Parameters.AddWithValue("@DataNascimento", _profissional.DataNascimento);
                cmd.Parameters.AddWithValue("@Foto", _profissional.Foto);
                cmd.Parameters.AddWithValue("@Ativo", _profissional.Ativo);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar profissonal no banco de dados", ex) { Data = { { "Id", 51 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Inserir(Profissional _profissional)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Profissonal(idfuncao, Nome, CPF, Logradouro, Numero, Bairro, Cidade, UF, Pais, CEP, DataNascimento,Foto,Ativo) 
                                    VALUES(@idfuncao, @Nome, @CPF, @Logradouro, @Numero, @Bairro, @Cidade, @UF, @Pais, @CEP, @DataNascimento,@Foto,@Ativo)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@idfuncao", _profissional.IdFuncao);
                cmd.Parameters.AddWithValue("@Nome", _profissional.Nome);
                cmd.Parameters.AddWithValue("@CPF", _profissional.CPF);
                cmd.Parameters.AddWithValue("@Logradouro", _profissional.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", _profissional.Numero);
                cmd.Parameters.AddWithValue("@Bairro", _profissional.Bairro);
                cmd.Parameters.AddWithValue("@Cidade", _profissional.Cidade);
                cmd.Parameters.AddWithValue("@UF", _profissional.UF);
                cmd.Parameters.AddWithValue("@Pais", _profissional.Pais);
                cmd.Parameters.AddWithValue("@CEP", _profissional.CEP);
                cmd.Parameters.AddWithValue("@DataNascimento", _profissional.DataNascimento);
                cmd.Parameters.AddWithValue("@Foto", _profissional.Foto);
                cmd.Parameters.AddWithValue("@Ativo", _profissional.Ativo);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um Profissional no banco de dados.", ex) { Data = { { "Id", 50 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Profissional> BuscarPorNome(string _nome)//Givas
        {
            List<Profissional> profissionalList = new List<Profissional>();
            Profissional profissional = new Profissional();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id,IdFuncao, Nome, CPF, Logradouro, Numero, Bairro, Cidade, UF, Pais, CEP, DataNascimento,Foto,Ativo FROM Profissional WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        profissional = new Profissional();
                        profissional.Id = (int)rd["Id"];
                        profissional.IdFuncao = (int)rd["IdFuncao"];
                        profissional.Nome = rd["Nome"].ToString();
                        profissional.CPF = rd["CPF"].ToString();
                        profissional.Logradouro = rd["Logradouro"].ToString();
                        profissional.Numero = rd["Numero"].ToString();
                        profissional.Bairro = rd["Bairro"].ToString();
                        profissional.Cidade = rd["Cidade"].ToString();
                        profissional.UF = rd["UF"].ToString();
                        profissional.Pais = rd["Pais"].ToString();
                        profissional.CEP = rd["CEP"].ToString();
                        profissional.DataNascimento = (DateTime)rd["DataNascimento"];

                        if (!String.IsNullOrEmpty(rd["Foto"].ToString()))
                            profissional.Foto = (byte[])rd["Foto"];

                        profissional.Ativo = (bool)rd["Ativo"];

                        profissional.EmailProfissional = new EmailProfissionalDAL().BuscarPorIdProfissional(profissional.Id);
                        profissional.TelefoneProfissional = new TelefoneProfissionalDAL().BuscarPorIdProfissional(profissional.Id);

                        profissionalList.Add(profissional);
                    }
                }
                return profissionalList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar profissional por nome no banco de dados", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Profissional> BuscarTodos()//Givas
        {
            List<Profissional> profissionalList = new List<Profissional>();
            Profissional profissional = new Profissional();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, IdFuncao, Nome, CPF, Logradouro, Numero, Bairro, Cidade, UF, Pais, CEP, DataNascimento, Foto, Ativo FROM Profissional";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        profissional = new Profissional();
                        profissional.Id = (int)rd["Id"];
                        profissional.IdFuncao = (int)rd["IdFuncao"];
                        profissional.Nome = rd["Nome"].ToString();
                        profissional.CPF = rd["CPF"].ToString();
                        profissional.Logradouro = rd["Logradouro"].ToString();
                        profissional.Numero = rd["Numero"].ToString();
                        profissional.Bairro = rd["Bairro"].ToString();
                        profissional.Cidade = rd["Cidade"].ToString();
                        profissional.UF = rd["UF"].ToString();
                        profissional.Pais = rd["Pais"].ToString();
                        profissional.CEP = rd["CEP"].ToString();
                        profissional.DataNascimento = (DateTime)rd["DataNascimento"];

                        if (!String.IsNullOrEmpty(rd["Foto"].ToString()))
                            profissional.Foto = (byte[])rd["Foto"];

                        profissional.Ativo = (bool)rd["Ativo"];
                        profissional.EmailProfissional = new EmailProfissionalDAL().BuscarPorIdProfissional(profissional.Id);
                        profissional.TelefoneProfissional = new TelefoneProfissionalDAL().BuscarPorIdProfissional(profissional.Id);

                        profissionalList.Add(profissional);
                    }
                }
                return profissionalList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar profissionais no banco de dados", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Profissional BuscarPorId(int _id)//Givas   ---   BUSCAR POR ID
        {
            Profissional profissional = new Profissional();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id,IdFuncao, Nome, CPF, Logradouro, Numero, Bairro, Cidade, UF, Pais, CEP, DataNascimento,Foto,Ativo FROM Profissional WHERE Id LIKE @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", "%" + _id + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        profissional = new Profissional();
                        profissional.Id = (int)rd["Id"];
                        profissional.IdFuncao = (int)rd["IdFuncao"];
                        profissional.Nome = rd["Nome"].ToString();
                        profissional.CPF = rd["CPF"].ToString();
                        profissional.Logradouro = rd["Logradouro"].ToString();
                        profissional.Numero = rd["Numero"].ToString();
                        profissional.Bairro = rd["Bairro"].ToString();
                        profissional.Cidade = rd["Cidade"].ToString();
                        profissional.UF = rd["UF"].ToString();
                        profissional.Pais = rd["Pais"].ToString();
                        profissional.CEP = rd["CEP"].ToString();
                        profissional.DataNascimento = (DateTime)rd["DataNascimento"];

                        if (!String.IsNullOrEmpty(rd["Foto"].ToString()))
                            profissional.Foto = (byte[])rd["Foto"];

                        profissional.Ativo = (bool)rd["Ativo"];
                        profissional.EmailProfissional = new EmailProfissionalDAL().BuscarPorIdProfissional(profissional.Id);
                        profissional.TelefoneProfissional = new TelefoneProfissionalDAL().BuscarPorIdProfissional(profissional.Id);
                    }
                }
                return profissional;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar profissionais por id no banco de dados", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }

        }
        public Profissional BuscarPorCPF(string _CPF)//Givas
        {
            Profissional profissional = new Profissional();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id,IdFuncao, Nome, CPF, Logradouro, Numero, Bairro, Cidade, UF, Pais, CEP, DataNascimento,Foto,Ativo FROM Profissional WHERE CPF LIKE @CPF";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CPF", "%" + _CPF + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        profissional = new Profissional();
                        profissional.Id = (int)rd["Id"];
                        profissional.IdFuncao = (int)rd["IdFuncao"];
                        profissional.Nome = rd["Nome"].ToString();
                        profissional.CPF = rd["CPF"].ToString();
                        profissional.Logradouro = rd["Logradouro"].ToString();
                        profissional.Numero = rd["Numero"].ToString();
                        profissional.Bairro = rd["Bairro"].ToString();
                        profissional.Cidade = rd["Cidade"].ToString();
                        profissional.UF = rd["UF"].ToString();
                        profissional.Pais = rd["Pais"].ToString();
                        profissional.CEP = rd["CEP"].ToString();
                        profissional.DataNascimento = (DateTime)rd["DataNascimento"];

                        if (!String.IsNullOrEmpty(rd["Foto"].ToString()))
                            profissional.Foto = (byte[])rd["Foto"];

                        profissional.Ativo = (bool)rd["Ativo"];
                        profissional.EmailProfissional = new EmailProfissionalDAL().BuscarPorIdProfissional(profissional.Id);
                        profissional.TelefoneProfissional = new TelefoneProfissionalDAL().BuscarPorIdProfissional(profissional.Id);
                    }
                }
                return profissional;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar profissional por CPF no banco de dados", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)//Givas
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Profissional WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir cliente no banco de dados.", ex) { Data = { { "Id", 12 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}


