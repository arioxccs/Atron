using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Atron
{
    /*CLASSE COM A CONEXÃO COM O BANCO DE DADOS (NO LOCAL DE PASSWORD COLOQUE A SENHA DO BANCO DA SUA MÁQUINA)*/
    internal class Connection
    {
        private static string connectionString = "server=localhost;user=root;password=nova_senha;database=atron_db";
        MySqlConnection connection = new MySqlConnection();

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
