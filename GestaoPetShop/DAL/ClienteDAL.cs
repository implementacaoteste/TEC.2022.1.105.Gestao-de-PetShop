﻿using Models;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DAL
{
    public class ClienteDAL
    {
        private int _idcliente = 0;
        public void Inserir(Cliente _cliente, SqlTransaction _transaction = null)
        {

            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Cliente(Nome, CPF, Logradouro, Numero, Bairro, Cidade, UF, Pais, CEP, DataNascimento,Foto,Ativo)
                                    VALUES(@Nome, @CPF, @Logradouro, @Numero, @Bairro, @Cidade, @UF, @Pais, @CEP, @DataNascimento,@Foto,@Ativo)", cn))
                {

                    cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                    cmd.Parameters.AddWithValue("@CPF", _cliente.CPF);
                    cmd.Parameters.AddWithValue("@Logradouro", _cliente.Logradouro);
                    cmd.Parameters.AddWithValue("@Numero", _cliente.Numero);
                    cmd.Parameters.AddWithValue("@Bairro", _cliente.Bairro);
                    cmd.Parameters.AddWithValue("@Cidade", _cliente.Cidade);
                    cmd.Parameters.AddWithValue("@UF", _cliente.UF);
                    cmd.Parameters.AddWithValue("@Pais", _cliente.Pais);
                    cmd.Parameters.AddWithValue("@CEP", _cliente.CEP);
                    cmd.Parameters.AddWithValue("@DataNascimento", _cliente.DataNascimento);
                    if (_cliente.Foto != null)
                        cmd.Parameters.AddWithValue("@Foto", _cliente.Foto);
                    else
                        cmd.Parameters.Add(new SqlParameter() { ParameterName = "@Foto", SqlDbType = System.Data.SqlDbType.Image, Value = DBNull.Value });


                    cmd.Parameters.AddWithValue("@Ativo", _cliente.Ativo);

                    if (_transaction == null)
                    {
                        cn.Open();
                        transaction = cn.BeginTransaction();
                    }

                    cmd.Transaction = transaction;
                    cmd.Connection = transaction.Connection;
                    try
                    {
                        cmd.ExecuteNonQuery();

                        int idcliente = BuscarIdCliente(_cliente, transaction, _idcliente);

                        InserirEmailCliente(_cliente, idcliente, transaction);

                        InserirTelefoneCliente(_cliente, idcliente, transaction);


                        if (_transaction == null)
                            transaction.Commit();
                    }



                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir um cliente no banco de dados.", ex) { Data = { { "Id", 10 } } };
                    }

                }
            }
        }

        private void InserirTelefoneCliente(Cliente _cliente, int _idcliente, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;
            List<Cliente> cliente = new List<Cliente>();

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO TelefoneCliente (IdCliente,Telefone)
                                                                              VALUES (@IdTelefone,@Telefone)", cn))
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

                        foreach (TelefoneCliente item in _cliente.TelefoneClientes)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@IdTelefone", _idcliente);
                            cmd.Parameters.AddWithValue("@Telefone", item.Telefone);


                            cmd.ExecuteNonQuery();
                        }

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir um telefone no banco de dados.", ex) { Data = { { "Id", 109 } } };
                    }
                }
            }
        }

        private void InserirEmailCliente(Cliente _cliente, int _idcliente, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;
            List<Cliente> cliente = new List<Cliente>();

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO EmailCliente (IdCliente,Email)
                                                                                 VALUES (@IdCliente,@Email)", cn))
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

                        foreach (EmailCliente item in _cliente.EmailCliente)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@IdCliente", _idcliente);
                            cmd.Parameters.AddWithValue("@Email", item.Email);


                            cmd.ExecuteNonQuery();
                        }

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir um e-mail no banco de dados.", ex) { Data = { { "Id", 107 } } };
                    }
                }
            }
        }

        private int BuscarIdCliente(Cliente _cliente, SqlTransaction _transaction, int _idcliente)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT Id FROM Cliente WHERE Nome LIKE @Nome", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);


                        if (transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                _idcliente = Convert.ToInt32(rd["Id"]);
                            }
                        }



                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar Buscar Idcliente no banco de dados.", ex) { Data = { { "Id", 106 } } };
                    }
                }
            }
            return _idcliente;
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
                                        Cidade = @Cidade,
                                        UF= @UF,
                                        Pais = @Pais,
                                        CEP = @CEP,
                                        DataNascimento = @DataNascimento,   
                                        Foto = @Foto,            
                                        Ativo = @Ativo
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _cliente.Id);
                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@CPF", _cliente.CPF);
                cmd.Parameters.AddWithValue("@Logradouro", _cliente.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", _cliente.Numero);
                cmd.Parameters.AddWithValue("@Bairro", _cliente.Bairro);
                cmd.Parameters.AddWithValue("@Cidade", _cliente.Cidade);
                cmd.Parameters.AddWithValue("@UF", _cliente.UF);
                cmd.Parameters.AddWithValue("@Pais", _cliente.Pais);
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
        public void AlterarEmailCliente(EmailCliente _emailCliente)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Cliente SET 
                                        Email = @Email, 
                                        
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _emailCliente.Id);
                cmd.Parameters.AddWithValue("@Email", _emailCliente.Email);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar Email no banco de dados", ex) { Data = { { "Id", 110 } } };
            }
            finally
            {
                cn.Close();
            }

        }
        public void AlterarTelefoneCliente(TelefoneCliente _telefoneCliente)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Cliente SET 
                                        Telefone = @Telefone, 
                                        
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _telefoneCliente.Id);
                cmd.Parameters.AddWithValue("@Telefone", _telefoneCliente.Telefone);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar telefone no banco de dados", ex) { Data = { { "Id", 111 } } };
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
        public void ExcluirEmailCliente(int _id)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM EmailCliente WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir emailcliente no banco de dados.", ex) { Data = { { "Id", 115 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void ExcluirTelefoneEmail(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM TelefoneCliente WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir telefonecliente no banco de dados.", ex) { Data = { { "Id", 116 } } };
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
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.Logradouro = rd["Logradouro"].ToString();
                        cliente.Numero = rd["Numero"].ToString();
                        cliente.Bairro = rd["Bairro"].ToString();
                        cliente.Cidade = rd["Cidade"].ToString();
                        cliente.UF = rd["UF"].ToString();
                        cliente.Pais = rd["Pais"].ToString();
                        cliente.CEP = rd["CEP"].ToString();
                        cliente.DataNascimento = (DateTime)rd["DataNascimento"];

                        if (!String.IsNullOrEmpty(rd["Foto"].ToString()))
                            cliente.Foto = (byte[])rd["Foto"];

                        cliente.Ativo = (bool)rd["Ativo"];


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
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.Logradouro = rd["Logradouro"].ToString();
                        cliente.Numero = rd["Numero"].ToString();
                        cliente.Bairro = rd["Bairro"].ToString();
                        cliente.Cidade = rd["Cidade"].ToString();
                        cliente.UF = rd["UF"].ToString();
                        cliente.Pais = rd["Pais"].ToString();
                        cliente.CEP = rd["CEP"].ToString();
                        cliente.DataNascimento = (DateTime)rd["DataNascimento"];

                        if (!String.IsNullOrEmpty(rd["Foto"].ToString()))
                            cliente.Foto = (byte[])rd["Foto"];

                        cliente.Ativo = (bool)rd["Ativo"];


                        clienteList.Add(cliente);
                    }
                }
                return clienteList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar clientes por nome no banco de dados", ex) { Data = { { "Id", 14 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<EmailCliente> BuscarEmailCliente(string _emailCliente)

        {
            List<EmailCliente> emailclienteList = new List<EmailCliente>();
            EmailCliente emailcliente = new EmailCliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Email FROM Cliente WHERE Email LIKE @Email";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Email", "%" + _emailCliente + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        emailcliente = new EmailCliente();
                        emailcliente.Id = (int)rd["Id"];
                        emailcliente.Email = rd["Email"].ToString();

                        emailclienteList.Add(emailcliente);
                    }
                }
                return emailclienteList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar EmailCliente no banco de dados", ex) { Data = { { "Id", 114 } } };
            }
            finally
            {
                cn.Close();
            }

        }
        public List<TelefoneCliente> BuscarTelefoneCliente(string _telefoneCliente)
        {
            List<TelefoneCliente> telefoneclienteList = new List<TelefoneCliente>();
            TelefoneCliente telefonecliente = new TelefoneCliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Telefone FROM Cliente WHERE Telefone LIKE @Telefone";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Telefone", "%" + _telefoneCliente + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        telefonecliente = new TelefoneCliente();
                        telefonecliente.Id = (int)rd["Id"];
                        telefonecliente.Telefone = rd["Telefone"].ToString();

                        telefoneclienteList.Add(telefonecliente);
                    }
                }
                return telefoneclienteList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar TelefoneCliente no banco de dados", ex) { Data = { { "Id", 115 } } };
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
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.Logradouro = rd["Logradouro"].ToString();
                        cliente.Numero = rd["Numero"].ToString();
                        cliente.Bairro = rd["Bairro"].ToString();
                        cliente.Cidade = rd["Cidade"].ToString();
                        cliente.UF = rd["UF"].ToString();
                        cliente.Pais = rd["Pais"].ToString();
                        cliente.CEP = rd["CEP"].ToString();
                        cliente.DataNascimento = (DateTime)rd["DataNascimento"];

                        if (!String.IsNullOrEmpty(rd["Foto"].ToString()))
                            cliente.Foto = (byte[])rd["Foto"];

                        cliente.Ativo = (bool)rd["Ativo"];

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
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.Logradouro = rd["Logradouro"].ToString();
                        cliente.Numero = rd["Numero"].ToString();
                        cliente.Bairro = rd["Bairro"].ToString();
                        cliente.Cidade = rd["Cidade"].ToString();
                        cliente.UF = rd["UF"].ToString();
                        cliente.Pais = rd["Pais"].ToString();
                        cliente.CEP = rd["CEP"].ToString();
                        cliente.DataNascimento = (DateTime)rd["DataNascimento"];

                        if (!String.IsNullOrEmpty(rd["Foto"].ToString()))
                            cliente.Foto = (byte[])rd["Foto"];

                        cliente.Ativo = (bool)rd["Ativo"];

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
