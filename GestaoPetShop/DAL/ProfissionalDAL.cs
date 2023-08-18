using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class ProfissionalDAL
    {
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

                    public List<Profissional> BuscarTodos()
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
        
    }
}


