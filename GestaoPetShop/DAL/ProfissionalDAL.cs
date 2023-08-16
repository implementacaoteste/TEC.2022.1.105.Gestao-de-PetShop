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

        //public List<Profissional> BuscarPorNomeProfissional(string _nomeProfissional, int _idProfissional)
        //{
        //    List<Profissional> listaProfissionais = new List<Profissional>();
        //    Profissional profissional;

        //    SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = cn;
        //        cmd.CommandText = @"SELECT Id, Nome FROM Profissional";

        //        if (_nomeProfissional != "" && _idProfissional == 0)
        //        {
        //            cmd.CommandText = cmd.CommandText + " WHERE UPPER (Nome) LIKE UPPER (@Nome)";
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.Parameters.AddWithValue("@Nome", "%" + _nomeProfissional + "%");
        //        }
        //        if (_nomeProfissional == "" && _idProfissional == 0)
        //        {
        //            cmd.CommandText = cmd.CommandText + " WHERE Id = @Id";
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.Parameters.AddWithValue("@Id", _idProfissional);
        //        }
        //        if (_nomeProfissional == "" && _idProfissional == 0)
        //        {
        //            cmd.CommandType = System.Data.CommandType.Text;
        //        }
        //        cn.Open();

        //        using (SqlDataReader rd = cmd.ExecuteReader())
        //        {
        //            while (rd.Read())
        //            {
        //                profissional = new Profissional();

        //                profissional.Id = Convert.ToInt32(rd["ID"]);
        //                profissional.Nome = rd["Nome"].ToString();

        //                listaProfissionais.Add(profissional);
        //            }
        //        }
        //        return listaProfissionais;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Ocorreu um erro ao tentar Listar todos os profissionais no banco de dados.", ex) { Data = { { "Id", 133 } } };
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //}
    }
}

