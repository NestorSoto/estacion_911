using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacion_911.Controlador
{
    internal class EmpleadoM
    {
        public static async Task showRoute()
        {
            var connection = mysql.getConexion();
            await connection.OpenAsync();
            string qwery = "SELECT v.vueloID, v.FechaSalida, v.FechaLlegada,co.Nombre, co.Pais , cd.Nombre, cd.Pais ,a.Marca, a.Modelo FROM vuelo v INNER JOIN ciudad cd ON cd.CiudadID = v.CiudadDestinoID INNER JOIN ciudad co ON co.CiudadID = v.CiudadOrigenID INNER JOIN avion a  ON a.AvionID = v.AvionID; ";
            var command = new MySqlCommand(qwery, connection);
            var reader = await command.ExecuteReaderAsync();
            Console.WriteLine("Mostrando lista de Rutas");
            Console.WriteLine("Codigo \tFecha de salida \t Fecha llegada \t cuidad origen \t Pais origen \t Ciudad destino \t Pais destino");
            while (await reader.ReadAsync())
            {

                Console.WriteLine(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3) + "\t" + reader.GetValue(4) + "\t" + reader.GetValue(5) + "\t" + reader.GetValue(6));
            }
        }
        public static void registrarPasajero(int codigo,String nombres,String apellidos,String DNI,String email,Boolean esadulto)
        {
            MySqlConnection conexion = mysql.getConexion();
            conexion.OpenAsync();
            string qwery = "CrearPasajero";
            MySqlCommand consulta = new MySqlCommand(qwery, conexion);
            consulta.CommandType = System.Data.CommandType.StoredProcedure;
            consulta.Parameters.Add(new MySqlParameter("VueloID", codigo));
            consulta.Parameters.Add(new MySqlParameter("PasajeroNombre", nombres));
            consulta.Parameters.Add(new MySqlParameter("PasajeroApellido", apellidos));
            consulta.Parameters.Add(new MySqlParameter("PasajeroDNI", DNI));
            consulta.Parameters.Add(new MySqlParameter("PasajeroEmail", email));
            consulta.Parameters.Add(new MySqlParameter("PasajeroAdulto", esadulto));
            consulta.ExecuteNonQuery();
            Console.WriteLine("Pasajero registrado con exito");
        }
    }

}
