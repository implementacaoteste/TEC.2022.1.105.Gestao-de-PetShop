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
        /*
                private void InserirTelefoneProfissional(Profissional _profissional, int _idprofissional, SqlTransaction _transaction)
                {
                    SqlTransaction transaction = _transaction;
                    List<Profissional> profissional = new List<Profissional>();

                    using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
                    {
                        using (SqlCommand cmd = new SqlCommand(@"INSERT INTO TelefoneProfissional (IdProfissional,Telefone)
                                                                                      VALUES (@IdProfissional,@Telefone)", cn))
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

                                foreach (Profissional item in _profissional.TelefoneProfissional)

                                    cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@IdProfissional", _idprofissional);
                                cmd.Parameters.AddWithValue("@Telefone", item.TelefoneProfissional);


                                cmd.ExecuteNonQuery();


                                if (_transaction == null)
                                    transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                throw new Exception("Ocorreu um erro ao tentar inserir um telefone no banco de dados.", ex) { Data = { { "Id", 57 } } };
                            }
                        }
                    }
                }

                    public List<Profissional> BuscarPorNome(string _nome)
                    {
                        throw new NotImplementedException();
                    }

                    public void Excluir(int _id)
                    {
                        throw new NotImplementedException();
                    }
        */
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
                        profissional.CPF = (int)rd["CPF"];
                        profissional.Logradouro = rd["Logradouro"].ToString();
                        profissional.Numero = (int)rd["Numero"];
                        profissional.Bairro = rd["Bairro"].ToString();
                        profissional.Cidade = rd["Cidade"].ToString();
                        profissional.UF = rd["UF"].ToString();
                        profissional.Pais = rd["Pais"].ToString();
                        profissional.CEP = (int)rd["CEP"];
                        profissional.DataNascimento = (int)rd["DataNascimento"];

                        //profissional.Nome = rd["Nome"].ToString();
                        //profissional.cpf = rd["cpf"].tostring();
                        //profissional.logradouro = rd["logradouro"].tostring();
                        //profissional.numero = rd["numero"].tostring();
                        //profissional.bairro = rd["bairro"].tostring();
                        //profissional.cidade = rd["cidade"].tostring();
                        //profissional.uf = rd["uf"].tostring();
                        //profissional.pais = rd["pais"].tostring();
                        //profissional.cep = rd["cep"].tostring();
                        //profissional.datanascimento = (datetime)rd["datanascimento"];

                        //if (!string.isnullorempty(rd["foto"].tostring()))
                        //    profissional.foto = (byte[])rd["foto"];

                        profissional.Ativo = (bool)rd["Ativo"];

                        //profissional.emailprofissional = new emailprofissionaldal().buscarporidprofissional(profissional.id);
                        //profissional.telefoneprofissional = new telefoneprofissionaldal().buscarporidprofissional(profissional.id);

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
                        profissional.CPF = (int)rd["CPF"];
                        profissional.Logradouro = rd["Logradouro"].ToString();
                        profissional.Numero = (int)rd["Numero"];
                        profissional.Bairro = rd["Bairro"].ToString();
                        profissional.Cidade = rd["Cidade"].ToString();
                        profissional.UF = rd["UF"].ToString();
                        profissional.Pais = rd["Pais"].ToString();
                        profissional.CEP = (int)rd["CEP"];
                        profissional.DataNascimento = (int)rd["DataNascimento"];

                        // if (!String.IsNullOrEmpty(rd["Foto"].ToString()))
                        //profissional.Foto = (byte[])rd["Foto"];

                        profissional.Ativo = (bool)rd["Ativo"];
                        //profissional.emailprofissional = new emailclientedal().buscarporidcliente(profissional.id);
                        //profissional.telefoneprofissional = new telefoneclientedal().buscarporidcliente(profissional.id);

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
                        profissional.CPF = (int)rd["CPF"];
                        profissional.Logradouro = rd["Logradouro"].ToString();
                        profissional.Numero = (int)rd["Numero"];
                        profissional.Bairro = rd["Bairro"].ToString();
                        profissional.Cidade = rd["Cidade"].ToString();
                        profissional.UF = rd["UF"].ToString();
                        profissional.Pais = rd["Pais"].ToString();
                        profissional.CEP = (int)rd["CEP"];
                        profissional.DataNascimento = (int)rd["DataNascimento"];

                        // if (!String.IsNullOrEmpty(rd["Foto"].ToString()))
                        //profissional.Foto = (byte[])rd["Foto"];

                        profissional.Ativo = (bool)rd["Ativo"];
                        //profissional.emailprofissional = new emailclientedal().buscarporidcliente(profissional.id);
                        //profissional.telefoneprofissional = new telefoneclientedal().buscarporidcliente(profissional.id);
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
                        profissional.CPF = (int)rd["CPF"];
                        profissional.Logradouro = rd["Logradouro"].ToString();
                        profissional.Numero = (int)rd["Numero"];
                        profissional.Bairro = rd["Bairro"].ToString();
                        profissional.Cidade = rd["Cidade"].ToString();
                        profissional.UF = rd["UF"].ToString();
                        profissional.Pais = rd["Pais"].ToString();
                        profissional.CEP = (int)rd["CEP"];
                        profissional.DataNascimento = (int)rd["DataNascimento"];

                        // if (!String.IsNullOrEmpty(rd["Foto"].ToString()))
                        //profissional.Foto = (byte[])rd["Foto"];

                        profissional.Ativo = (bool)rd["Ativo"];
                        //profissional.emailprofissional = new emailclientedal().buscarporidcliente(profissional.id);
                        //profissional.telefoneprofissional = new telefoneclientedal().buscarporidcliente(profissional.id);
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


