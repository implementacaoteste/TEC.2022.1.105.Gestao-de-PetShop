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
        public void Alterar(Profissional _profissional, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Profissional SET IdFuncao = @IdFuncao, Nome = @Nome, CPF = @CPF, 
                                        Logradouro = @Logradouro, Numero = @Numero, Bairro = @Bairro,
                                        Cidade = @Cidade, UF= @UF, Pais = @Pais, CEP = @CEP, DataNascimento = @DataNascimento,
                                        Foto = @Foto, Ativo = @Ativo WHERE Id = @Id";

                //cmd.CommandText = @"UPDATE Profissional SET Idfuncao = @Idfuncao, Nome = @Nome, CPF = @CPF, 
                //                        Logradouro = @Logradouro, Numero = @Numero, Bairro = @Bairro,
                //                        Cidade = @Cidade, UF= @UF, Pais = @Pais, CEP = @CEP, DataNascimento = @DataNascimento,
                //                        Foto = @Foto, Ativo = @Ativo WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _profissional.Id);
                cmd.Parameters.AddWithValue("@Idfuncao", _profissional.IdFuncao);
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

                if (_profissional.Foto != null)
                    cmd.Parameters.AddWithValue("@Foto", _profissional.Foto);
                else
                    cmd.Parameters.Add(new SqlParameter() { ParameterName = "@Foto", SqlDbType = System.Data.SqlDbType.Image, Value = DBNull.Value });

                cmd.Parameters.AddWithValue("@Ativo", _profissional.Ativo);

                if (transaction == null)
                {
                    cn.Open();
                    transaction = cn.BeginTransaction();
                }
                cmd.Transaction = transaction;
                cmd.Connection = transaction.Connection;

                cmd.ExecuteNonQuery();

                foreach (EmailProfissional emailProfissional in _profissional.EmailProfissional)
                {
                    emailProfissional.IdProfissional = _profissional.Id;
                    if (emailProfissional.Id == 0)
                        new EmailProfissionalDAL().Inserir(emailProfissional, transaction);
                }
                foreach (TelefoneProfissional telefoneProfissional in _profissional.TelefoneProfissional)
                {
                    telefoneProfissional.IdProfissional = _profissional.Id;
                    if (telefoneProfissional.Id == 0)
                        new TelefoneProfissionalDAL().Inserir(telefoneProfissional, transaction);
                }
                if (_transaction == null)
                    transaction.Commit();
            }
            catch (Exception ex)
            {
                if (transaction != null && transaction.Connection != null)
                    transaction.Rollback();
                throw new Exception("Erro ao tentar Alterar um Profissonal no banco de dados", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }
        }//Givas
        public void Inserir(Profissional _profissional, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Profissional(IdFuncao, Nome, CPF, Logradouro, Numero, Bairro, Cidade, UF, Pais, CEP, DataNascimento, Foto, Ativo)
                                                                VALUES (@IdFuncao, @Nome, @CPF, @Logradouro, @Numero, @Bairro, @Cidade, @UF, @Pais, @CEP, @DataNascimento, @Foto, @Ativo) SELECT @@IDENTITY", cn))
                {
                    cmd.Parameters.AddWithValue("@IdFuncao", _profissional.IdFuncao);
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

                    if (_profissional.Foto != null)
                        cmd.Parameters.AddWithValue("@Foto", _profissional.Foto);
                    else
                        cmd.Parameters.Add(new SqlParameter() { ParameterName = "@Foto", SqlDbType = System.Data.SqlDbType.Image, Value = DBNull.Value });

                    cmd.Parameters.AddWithValue("@Ativo", _profissional.Ativo);

                    if (_transaction == null)
                    {
                        cn.Open();
                        transaction = cn.BeginTransaction();
                    }
                    cmd.Transaction = transaction;
                    cmd.Connection = transaction.Connection;
                    try
                    {
                        int _idprofissional = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (EmailProfissional emailProfissional in _profissional.EmailProfissional)
                        {
                            emailProfissional.IdProfissional = _idprofissional;
                            new EmailProfissionalDAL().Inserir(emailProfissional, transaction);
                        }

                        foreach (TelefoneProfissional telefoneProfissional in _profissional.TelefoneProfissional)
                        {
                            telefoneProfissional.IdProfissional = _idprofissional;
                            new TelefoneProfissionalDAL().Inserir(telefoneProfissional, transaction);
                        }

                        if (_transaction == null)
                        {
                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar Inserir um Profissional no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }//Givas
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
                cmd.CommandText = @"SELECT Profissional.Id, Profissional.IdFuncao, Profissional.Nome, Profissional.CPF, 
                                            Profissional.Logradouro, Profissional.Numero, Profissional.Bairro, 
                                            Profissional.Cidade, Profissional.UF, Profissional.Pais, Profissional.CEP, 
                                            Profissional.DataNascimento, Profissional.Foto, Profissional.Ativo, 
                                                Funcao.Nome AS NomeFuncao FROM Profissional 
                                            INNER JOIN Funcao ON Profissional.IdFuncao = Funcao.Id";
                //cmd.CommandText = @"SELECT Id, Nome, CPF, Logradouro, Numero, Bairro, Cidade, UF, Pais, CEP, DataNascimento, Foto, Ativo FROM Profissional";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        profissional = new Profissional();
                        profissional.Id = (int)rd["Id"];
                        profissional.IdFuncao = (int)rd["IdFuncao"];
                        profissional.NomeFuncao = rd["NomeFuncao"].ToString();
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
                cmd.CommandText = @"SELECT Profissional.Id, Profissional.IdFuncao, Profissional.Nome, Profissional.CPF, 
                                            Profissional.Logradouro, Profissional.Numero, Profissional.Bairro, 
                                            Profissional.Cidade, Profissional.UF, Profissional.Pais, Profissional.CEP, 
                                            Profissional.DataNascimento, Profissional.Foto, Profissional.Ativo, 
                                                Funcao.Nome AS NomeFuncao FROM Profissional 
                                            INNER JOIN Funcao ON Profissional.IdFuncao = Funcao.Id WHERE Profissional.Id = @Id";
                //cmd.CommandText = @"SELECT Id,IdFuncao, Nome, CPF, Logradouro, Numero, Bairro, Cidade, UF, Pais, CEP, DataNascimento, Foto, Ativo FROM Profissional WHERE Id LIKE @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                //cmd.Parameters.AddWithValue("@Id", "%" + _id + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        profissional.Id = (int)rd["Id"];
                        profissional.IdFuncao = (int)rd["IdFuncao"];
                        profissional.NomeFuncao = rd["NomeFuncao"].ToString();
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
                throw new Exception("Ocorreu um erro ao tentar Excluir um Profissional no banco de dados.", ex) { Data = { { "Id", -1 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}


