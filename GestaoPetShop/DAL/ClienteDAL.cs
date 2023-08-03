using Models;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace DAL
{
    public class ClienteDAL
    {
        public void Inserir(Cliente _cliente)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Cliente(Nome, CPF, Logradouro, Numero, Bairro, Cidade, UF, Pais, CEP, DataNascimento,Foto,Ativo) 
                                    VALUES(@Nome, @CPF, @Logradouro, @Numero, @Bairro, @Cidade, @UF, @Pais, @CEP, @DataNascimento,@Foto,@Ativo)";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@CPF", _cliente.CPF);
                cmd.Parameters.AddWithValue("@Logradouro", _cliente.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", _cliente.Numero);
                cmd.Parameters.AddWithValue("@Bairro", _cliente.Bairro);
                cmd.Parameters.AddWithValue("@Cidade", _cliente.Cidade);
                cmd.Parameters.AddWithValue("@UF", _cliente.UF);
                cmd.Parameters.AddWithValue("@Pais", _cliente.Pais);
                cmd.Parameters.AddWithValue("@CEP", _cliente.CEP);
                cmd.Parameters.AddWithValue("@DataNascimento",_cliente.DataNascimento);
                cmd.Parameters.AddWithValue("@Foto", _cliente.Foto);
               cmd.Parameters.AddWithValue("@Ativo",_cliente.Ativo);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um cliente no banco de dados.", ex) { Data = { { "Id", 10 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Cliente _cliente)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Cliente SET 
                                        Nome = @Nome, 
                                        CPF = @CPF, 
                                        Logradouro = @Logradouro, 
                                        Numero = @Numero, 
                                        Bairro = @Bairro,
                                        Cidade @Cidade,
                                        UF= @UF,
                                        Pais = @Pais,
                                        CEP = @CEP,
                                        DataNascimento = @DataNascimento,   
                                        Foto = @Foto,            
                                        Ativo = @Ativo,
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _cliente.Id);
                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@CPF", _cliente.CPF);
                cmd.Parameters.AddWithValue("@Logradouro", _cliente.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", _cliente.Numero);
                cmd.Parameters.AddWithValue("@Bairro", _cliente.Bairro);
                cmd.Parameters.AddWithValue("@Cidade",_cliente.Cidade);
                cmd.Parameters.AddWithValue("@UF", _cliente.UF);
                cmd.Parameters.AddWithValue("@Pais",_cliente.Pais);
                cmd.Parameters.AddWithValue("@CEP", _cliente.CEP);
                cmd.Parameters.AddWithValue("@DataNascimento", _cliente.DataNascimento);
                cmd.Parameters.AddWithValue("@Foto", _cliente.Foto);
                cmd.Parameters.AddWithValue("@Ativo", _cliente.Ativo);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar cliente no banco de dados", ex) { Data = { { "Id", 11 } } };
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
                cmd.CommandText = @"DELETE FROM Cliente WHERE id = @id";
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
        public List<Cliente> BuscarTodos()
        {
            List<Cliente> clienteList = new List<Cliente>();
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, Logradouro, Numero, Bairro, Cidade, UF, Pais, CEP, DataNascimento,Foto,Ativo FROM Cliente";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.CPF = (int)rd["CPF"];
                        cliente.Logradouro = rd["Logradouro"].ToString();
                        cliente.Numero = (int)rd["Numero"];
                        cliente.Bairro = rd["Bairro"].ToString();
                        cliente.Cidade = rd["Cidade"].ToString();
                        cliente.UF = rd["UF"].ToString();
                        cliente.Pais = rd["Pais"].ToString();
                        cliente.CEP = (int)rd["CEP"];
                        cliente.DataNascimento = (int)rd["DataNascimento"]; //verificar
                        cliente.Foto = (byte)rd["Foto"];
                        cliente.Ativo = (bool)rd["Ativo"]; //verificar


                        clienteList.Add(cliente);
                    }
                }
                return clienteList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar clientes no banco de dados", ex) { Data = { { "Id", 13 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Cliente> BuscarPorNome(string _nome)
        {
            List<Cliente> clienteList = new List<Cliente>();
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CPF, Logradouro, Numero, Bairro, Cidade, UF, Pais, CEP, DataNascimento,Foto,Ativo FROM Cliente WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.CPF = (int)rd["CPF"];
                        cliente.Logradouro = rd["Logradouro"].ToString();
                        cliente.Numero = (int)rd["Numero"];
                        cliente.Bairro = rd["Bairro"].ToString();
                        cliente.Cidade = rd["Cidade"].ToString();
                        cliente.UF = rd["UF"].ToString();
                        cliente.Pais = rd["Pais"].ToString();
                        cliente.CEP = (int)rd["CEP"];
                        cliente.DataNascimento = (int)rd["DataNascimento"]; //verificar
                        cliente.Foto = (byte)rd["Foto"];
                        cliente.Ativo = (bool)rd["Ativo"]; //verificar


                        clienteList.Add(cliente);
                    }
                }
                return clienteList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar clientes por nome no banco de dados", ex) { Data = { { "Id", 14  } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Cliente BuscarPorId(int _id)  // BuscarPorCodigo
        {
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id,Nome, CPF, Logradouro, Numero, Bairro, Cidade, UF, Pais, CEP, DataNascimento,Foto,Ativo FROM Cliente WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.CPF = (int)rd["CPF"];
                        cliente.Logradouro = rd["Logradouro"].ToString();
                        cliente.Numero =(int) rd["Numero"];
                        cliente.Bairro = rd["Bairro"].ToString();
                        cliente.Cidade = rd["Cidade"].ToString();
                        cliente.UF = rd["UF"].ToString();
                        cliente.Pais = rd["Pais"].ToString();
                        cliente.CEP = (int)rd["CEP"];
                        cliente.DataNascimento = (int)rd["DataNascimento"]; //verificar
                        cliente.Foto = (byte)rd["Foto"];
                        cliente.Ativo = (bool)rd["Ativo"]; //verificar

                    }
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar clientes por id no banco de dados", ex) { Data = { { "Id", 15 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Cliente BuscarPorCPF(string _CPF)
        {
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id,Nome, CPF, Logradouro, Numero, Bairro, Cidade, UF, Pais, CEP, DataNascimento,Foto,Ativo FROM Cliente WHERE CPF = @CPF";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CPF", _CPF);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.CPF = (int)rd["CPF"];
                        cliente.Logradouro = rd["Logradouro"].ToString();
                        cliente.Numero = (int)rd["Numero"];
                        cliente.Bairro = rd["Bairro"].ToString();
                        cliente.Cidade = rd["Cidade"].ToString();
                        cliente.UF = rd["UF"].ToString();
                        cliente.Pais = rd["Pais"].ToString();
                        cliente.CEP = (int)rd["CEP"];
                        cliente.DataNascimento = (int)rd["DataNascimento"]; //verificar
                        cliente.Foto = (byte)rd["Foto"];
                        cliente.Ativo = (bool)rd["Ativo"]; //verificar

                    }
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar clientes por CPF no banco de dados", ex) { Data = { { "Id", 16 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        
       
        
    }
}
