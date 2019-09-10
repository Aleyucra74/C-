using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace necessarios para conexao ao banco de dados
using AcessoBanco;
using System.Data;
using System.Data.SqlClient;

namespace TransferenciaDados
{
    public class ClienteDTO
    {
        int _CodigoCliente;
        string _Nome;
        string _Telefone;
        string _Endereco;
        string _Bairro;

        public int CodigoCliente
        {
            get { return _CodigoCliente; }
            set { _CodigoCliente = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

        public string Endereco
        {
            get { return _Endereco; }
            set { _Endereco = value; }
        }

        public string Bairro
        {
            get { return _Bairro; }
            set { _Bairro = value; }
        }
    }

    public class SalvarCliente
    {
        public void IncluirCliente(ClienteDTO dados)
        {
            //definir parametros para o sql server
            //tratamento de excessoes
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InserirClientes", Conexao.obterConexao());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome",dados.Nome);
                cmd.Parameters.AddWithValue("@telefone", dados.Telefone);
                cmd.Parameters.AddWithValue("@endereco", dados.Endereco);
                cmd.Parameters.AddWithValue("@bairro", dados.Bairro);

                //executar os comandos sql
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {

            }
            finally
            {

            }
        }


    }
}
