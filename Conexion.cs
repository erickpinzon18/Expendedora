using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace Expendedora
{
    internal class Conexion
    {
        string servidor = "localhost";
        string bd = "expendedora";
        string usuario = "root";
        string password = "";
        public MySqlConnection connection;

        public Conexion()
        {
            Conectar();
        }

        private void Conectar()
        {
            string connectionString;
            connectionString = "server=" + servidor + ";" +
                "database=" + bd + ";" +
                "id usuario=" + usuario + ";" +
                "password=" + password + ";";
            connection = new MySqlConnection(connectionString);


        }

        public bool abrirBD()
        {
            try
            {
                connection.Open();
                Console.WriteLine("BD Conectada");
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error, BD no conectada" + ex);
                return false;
            }
        }
    }


}
