using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace Expendedora
{
    internal class Conexion
    {
        // DECLARACION DE ATRIBUTOS PARA REALIZAR LA CONEXION
        string servidor = "localhost";
        string bd = "dispensador";
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
                "user id=" + usuario + ";" +
                "password=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        // METODO PARA ABRIR LA BD

        public bool abrirBD()
        {
            try
            {
                connection.Open();
                Console.WriteLine("BD conectada");
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error, BD No conectada" + ex);
                return false;
            }
        }


        // METODO PARA CERRAR LA BD

        public bool cerrarBD()
        {
            try
            {
                connection.Close();
                Console.WriteLine("BD desconectada");
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error, BD No se desconecto" + ex);
                return false;
            }
        }
    }
}
