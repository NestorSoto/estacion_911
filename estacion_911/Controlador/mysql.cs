using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacion_911.Controlador
{
    internal class mysql
    {
        public static MySqlConnection getConexion()
        {
            String servidor = "127.0.0.1";
            String db = "estacion911";
            String user = "root";
            string pass = "";
            MySqlConnection conexion = new MySqlConnection//();
            ("server=127.0.0.1;database=estacion911;Uid=root;pass=;");
            return conexion;
        }
    }
}
