using MySqlConnector;
using System;

namespace estacion_911.Controlador
{
    internal class mysql
    {
        public static MySqlConnection getConexion()
        {
            MySqlConnection conexion = new MySqlConnection//();
            ("server=127.0.0.1;database=estacion911;Uid=root;pass=;");
            return conexion;
        }
    }
}
