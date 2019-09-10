using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace para conexao e acesso a dados
//conexao para o bd
using System.Data;
using System.Data.SqlClient;

using AcessoBanco.Properties;

namespace AcessoBanco
{
   public class Conexao
    {
        //criar conexao
        private static string strConn = Settings.Default.strConexao;

        //representa a conexao com o banco
        private static SqlConnection conn = null;

        //metodo que permite obter a conexao

        public static SqlConnection obterConexao()
        {
            //vamos criar a conexao
            //instanciar
            conn = new SqlConnection(strConn);
            //tratamento de excessoes
            try
            {
                //abre a conexao e a devolve ao chamador do metedo
                conn.Open();
            }
            catch(SqlException e)
            {
                //retorna a variavel como nulo
                conn = null;
                //apresentar a mensagem de excessao
                throw e;
            }
            return conn;


        }
    }
}
