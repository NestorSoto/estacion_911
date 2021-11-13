using estacion_911.Modelos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;

namespace estacion_911.Controlador
{
    internal class Administrador
    {
        //MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        static async Task showCities()
        {
            var connection = mysql.getConexion();
            await connection.OpenAsync();

            var command = new MySqlCommand("SELECT * FROM ciudad;", connection);
            var reader = await command.ExecuteReaderAsync();
            Console.WriteLine("Mostrando lista de cuidades\n CIUDAD || PAIS");
            while (await reader.ReadAsync())
            {

                Console.WriteLine(reader.GetValue(1) + " || " + reader.GetValue(2));
            }
        }
        static async Task showAirplane()
        {
            var connection = mysql.getConexion();
            await connection.OpenAsync();

            var command = new MySqlCommand("SELECT * FROM avion;", connection);
            var reader = await command.ExecuteReaderAsync();
            Console.WriteLine("Mostrando lista de Aviones \n Marca || modelo || Capacidad");
            while (await reader.ReadAsync())
            {

                Console.WriteLine(reader.GetValue(2) + " || " + reader.GetValue(3) + " || " + reader.GetValue(1));
            }
        }
        

        public static async Task<List<object>> ObtenerAvionesAsync()
        {
            List<object> lista = new List<Object>();
            var connection = mysql.getConexion();
            await connection.OpenAsync();

            var command = new MySqlCommand("SELECT * FROM avion;", connection);
            var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {

                Console.WriteLine(reader.GetValue(2) + " || " + reader.GetValue(3) + " || " + reader.GetValue(1));
                AvionM a = new AvionM();
                a.Id = int.Parse((String)reader.GetValue(0));
                a.Marca = (string)reader.GetValue(2);
                a.Modelo = (String)reader.GetValue(5);
                a.Capacidad = int.Parse((String)reader.GetValue(1));
                lista.Add(a);


            }

            return lista;
        }
        public static void eliminarAvion(String marcaD, String modeloD)
        {
            MySqlConnection conexionD = mysql.getConexion();
            conexionD.OpenAsync();
            string qweryD = "DELETE FROM avion WHERE Marca=@marcaD and Modelo=@modelo";
            MySqlCommand consultaD = new MySqlCommand(qweryD, conexionD);
            consultaD.Parameters.AddWithValue("@marcaD", marcaD);
            consultaD.Parameters.AddWithValue("@modelo", modeloD);
            consultaD.ExecuteNonQuery();
        }

        public static DataTable MostrarAviones()
        {
            var connection = mysql.getConexion();
            connection.Open();

            var command = new MySqlCommand("SELECT * FROM avion;", connection);
            var reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Marca", typeof(String));
            dt.Columns.Add("Modelo", typeof(String));
            dt.Columns.Add("Capacidad", typeof(int));


            while (reader.Read())
            {
                //Console.WriteLine(reader.GetValue(),reader.GetValue(2) + " || " + reader.GetValue(3) + " || " + reader.GetValue(1));
                dt.Rows.Add(new Object[] { reader.GetValue(0), reader.GetValue(2), reader.GetValue(3), reader.GetValue(1) });
            }
            return dt;

        }
        public static void registrar(String marca, String modelo, int capacidad)
        {
            MySqlConnection conexion = mysql.getConexion();
            conexion.OpenAsync();
            string qwery = "INSERT INTO avion(Capacidad,Marca,Modelo) VALUES(@capacidad,@marca,@modelo)";
            MySqlCommand consulta = new MySqlCommand(qwery, conexion);
            consulta.Parameters.AddWithValue("@capacidad", capacidad);
            consulta.Parameters.AddWithValue("@marca", marca);
            consulta.Parameters.AddWithValue("@modelo", modelo);
            consulta.ExecuteNonQuery();
        }
        public static DataTable MostrarRutas()
        {
            var connection = mysql.getConexion();
            connection.Open();

            var command = new MySqlCommand("SELECT v.vueloID, v.FechaSalida, v.FechaLlegada,co.Nombre, co.Pais , cd.Nombre, cd.Pais ,a.Marca, a.Modelo FROM vuelo v INNER JOIN ciudad cd ON cd.CiudadID = v.CiudadDestinoID INNER JOIN ciudad co ON co.CiudadID = v.CiudadOrigenID INNER JOIN avion a  ON a.AvionID = v.AvionID; ", connection);
            var reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("fecha Salida", typeof(String));
            dt.Columns.Add("fecha Llegada", typeof(String));
            dt.Columns.Add("ciudad origen", typeof(String));
            dt.Columns.Add("Pais Origen", typeof(String));
            dt.Columns.Add("ciudad destino", typeof(String));
            dt.Columns.Add("pais destino", typeof(String));

            while (reader.Read())
            {
                //Console.WriteLine(reader.GetValue(),reader.GetValue(2) + " || " + reader.GetValue(3) + " || " + reader.GetValue(1));

                dt.Rows.Add(new Object[] { reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6) });
            }
            return dt;

        }
        public static DataTable MostrarCiudades()
        {
            var connection = mysql.getConexion();
            connection.Open();

            var command = new MySqlCommand("SELECT * FROM ciudad; ", connection);
            var reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Nombre", typeof(String));
            dt.Columns.Add("Pais", typeof(String));


            while (reader.Read())
            {
                //Console.WriteLine(reader.GetValue(),reader.GetValue(2) + " || " + reader.GetValue(3) + " || " + reader.GetValue(1));
                dt.Rows.Add(new Object[] { reader.GetValue(0), reader.GetValue(1), reader.GetValue(2) });
            }
            return dt;

        }
        public static void registrarCiudad(String ciudad, String pais)
        {
            MySqlConnection conexion = mysql.getConexion();
            conexion.OpenAsync();
            string qwery = "INSERT INTO ciudad (Nombre,Pais) VALUES(@ciudad,@pais)";
            MySqlCommand consulta = new MySqlCommand(qwery, conexion);
            consulta.Parameters.AddWithValue("@ciudad", ciudad);
            consulta.Parameters.AddWithValue("@pais", pais);
            consulta.ExecuteNonQuery();
        }
        public static void EliminarCiudad(String ciudadD, String paisD)
        {
            MySqlConnection conexionD = mysql.getConexion();
            conexionD.OpenAsync();
            string qweryD = "DELETE FROM ciudad WHERE Nombre=@ciudad and Pais=@pais";
            MySqlCommand consultaD = new MySqlCommand(qweryD, conexionD);
            consultaD.Parameters.AddWithValue("@ciudad", ciudadD);
            consultaD.Parameters.AddWithValue("@pais", paisD);
            consultaD.ExecuteNonQuery();
        }





    }
}
