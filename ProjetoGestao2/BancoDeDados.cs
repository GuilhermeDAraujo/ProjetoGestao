using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGestao2
{
    static class BancoDeDados
    {
        private const string servidor = "localhost";
        private const string bancoDeDados = "projeto";
        private const string usuario = "root";
        private const string senha = "123456";

        // metodo conectar ao banco de dados
        static public string Conectar()
        {
            string strConn = $"server={servidor};User Id={usuario};database={bancoDeDados};password={senha};";
            return strConn;
        }
        // metodo para abrir a conexao com o banco de dados
        static public MySqlConnection AbrirConexao()
        {
            MySqlConnection conexao = new MySqlConnection(Conectar());
            conexao.Open();
            return conexao;
        }
    }
}
