using Models;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using iText.Signatures;
using System.Transactions;

namespace DAL
{
    public class ClienteDAL
    {

        public void Inserir(Cliente _cliente, SqlTransaction _transaction = null)
        {

            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Cliente(Nome, CPF, Logradouro, Numero, Bairro, Cidade, UF, Pais, CEP, DataNascimento,Foto,Ativo)
                                                VALUES(@Nome, @CPF, @Logradouro, @Numero, @Bairro, @Cidade, @UF, @Pais, @CEP, @DataNascimento,@Foto,@Ativo) SELECT @@IDENTITY", cn))
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
                        // cmd.ExecuteNonQuery();
                        int _idcliente = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (EmailCliente emailCliente in _cliente.EmailCliente)
                        {
                            emailCliente.IdCliente = _idcliente;
                            new EmailClienteDAL().Inserir(emailCliente, transaction);

                        }

                        foreach (TelefoneCliente telefoneCliente in _cliente.TelefoneClientes)
                        {
                            telefoneCliente.IdCliente = _idcliente;
                            new TelefoneClienteDAL().Inserir(telefoneCliente, transaction);

                        }


                        if (_transaction == null)
                            transaction.Commit();
                    }



                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar inserir um cliente no banco de dados.", ex) { Data = { { "Id", 10 } } };
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
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar Buscar Idcliente no banco de dados.", ex) { Data = { { "Id", 106 } } };
                    }
                }
            }
            return _idcliente;
        }
        public void Alterar(Cliente _cliente, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Cliente SET Nome = @Nome, CPF = @CPF, Logradouro = @Logradouro, 
                                        Numero = @Numero, Bairro = @Bairro, Cidade = @Cidade, UF= @UF,
                                        Pais = @Pais, CEP = @CEP, DataNascimento = @DataNascimento,   
                                        Foto = @Foto, Ativo = @Ativo WHERE Id = @Id";
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

                if (_cliente.Foto != null)
                    cmd.Parameters.AddWithValue("@Foto", _cliente.Foto);
                else
                    cmd.Parameters.Add(new SqlParameter() { ParameterName = "@Foto", SqlDbType = System.Data.SqlDbType.Image, Value = DBNull.Value });

                cmd.Parameters.AddWithValue("@Ativo", _cliente.Ativo);

                if (transaction == null)
                {
                    cn.Open();
                    transaction = cn.BeginTransaction();
                }

                cmd.Transaction = transaction;
                cmd.Connection = transaction.Connection;

                cmd.ExecuteNonQuery();

                foreach (EmailCliente emailCliente in _cliente.EmailCliente)
                {
                    emailCliente.IdCliente = _cliente.Id;
                    if (emailCliente.Id == 0)
                        new EmailClienteDAL().Inserir(emailCliente, transaction);
                    //else
                    //    new EmailClienteDAL().Alterar(emailCliente, _transaction);
                }

                foreach (TelefoneCliente telefoneCliente in _cliente.TelefoneClientes)
                {
                    telefoneCliente.IdCliente = _cliente.Id;
                    if (telefoneCliente.Id == 0)
                        new TelefoneClienteDAL().Inserir(telefoneCliente, transaction);
                    //else
                    //    new TelefoneClienteDAL().Alterar(telefoneCliente, _transaction);
                }

                if (_transaction == null)
                    transaction.Commit();
            }
            catch (Exception ex)
            {
                if (transaction != null && transaction.Connection != null)
                    transaction.Rollback();
                throw new Exception("Erro ao tentar alterar cliente no banco de dados", ex) { Data = { { "Id", 11 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(Cliente _cliente, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"DELETE FROM Cliente WHERE Id = @Id", cn))
                {
                    cmd.Parameters.AddWithValue("@Id", _cliente.Id);
                    if (_transaction == null)
                    {
                        cn.Open();
                        transaction = cn.BeginTransaction();
                    }
                    cmd.Transaction = transaction;
                    cmd.Connection = transaction.Connection;
                    try
                    {
                        if (_cliente.EmailCliente.Count > 0)
                        {
                            ExcluirEmailCliente(_cliente, _cliente.EmailCliente, transaction);
                        }
                        if (_cliente.TelefoneClientes.Count > 0)
                        {
                            ExcluirTelefoneCliente(_cliente, _cliente.TelefoneClientes, transaction);
                        }

                        
                            ExcluirAnimaldoCliente(_cliente.Id,transaction);
                        

                        cmd.ExecuteNonQuery();
                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir agendamento no banco de dados.", ex) { Data = { { "Id", -1 } } };
                    }
                }
            }
        }


        private void ExcluirAnimaldoCliente(int _id, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))

            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Animal WHERE IdCliente = @Id", cn))
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

                        cmd.CommandType = System.Data.CommandType.Text;

                        
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@Id", _id);
                            cmd.ExecuteNonQuery();
                       
                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir o E-mail do Cliente do banco de dados.", ex) { Data = { { "Id", 32 } } };
                    }
                }
            }
        }

        private void ExcluirEmailCliente(Cliente _cliente, List<EmailCliente> _emailCliente, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM EmailCliente WHERE Id = @Id", cn))
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

                        cmd.CommandType = System.Data.CommandType.Text;
                        foreach (EmailCliente item in _emailCliente)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@Id", item.Id);
                            cmd.ExecuteNonQuery();
                        }
                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir o E-mail do Cliente do banco de dados.", ex) { Data = { { "Id", 32 } } };
                    }
                }
            }
        }

        private void ExcluirTelefoneCliente(Cliente _cliente, List<TelefoneCliente> _telefoneClientes, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM TelefoneCliente WHERE Id = @Id", cn))
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

                        cmd.CommandType = System.Data.CommandType.Text;
                        foreach (TelefoneCliente item in _telefoneClientes)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@Id", item.Id);
                            cmd.ExecuteNonQuery();
                        }
                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction != null && transaction.Connection != null)
                            transaction.Rollback();
                        throw new Exception("Ocorreu um erro ao tentar excluir o Telefone do Cliente do banco de dados.", ex) { Data = { { "Id", 32 } } };
                    }
                }
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
                        cliente.EmailCliente = new EmailClienteDAL().BuscarPorIdCliente(cliente.Id);
                        cliente.TelefoneClientes = new TelefoneClienteDAL().BuscarPorIdCliente(cliente.Id);
                        
                        cliente.Animais = new AnimalDAL().BuscarAnimaisPorIdCliente(cliente.Id);
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

                        cliente.EmailCliente = new EmailClienteDAL().BuscarPorIdCliente(cliente.Id);
                        cliente.TelefoneClientes = new TelefoneClienteDAL().BuscarPorIdCliente(cliente.Id);

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
                        cliente.EmailCliente = new EmailClienteDAL().BuscarPorIdCliente(cliente.Id);
                        cliente.TelefoneClientes = new TelefoneClienteDAL().BuscarPorIdCliente(cliente.Id);

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

                        cliente.EmailCliente = new EmailClienteDAL().BuscarPorIdCliente(cliente.Id);
                        cliente.TelefoneClientes = new TelefoneClienteDAL().BuscarPorIdCliente(cliente.Id);
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
        public bool ExisteVinculoClienteComAgendamento(int _idCliente)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 AS retorno FROM Cliente C INNER JOIN Animal A ON C.Id = A.IdCliente
                                                                       INNER JOIN Agendamento Ag ON A.Id = Ag.IdAnimal
                                                                       WHERE  C.Id = @IdCliente";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdCliente", _idCliente);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar vínculos de Cliente com Agendamento: " + ex.Message) { Data = { { "Id", 45 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
