using System;

namespace estacion_911.Modelos
{
    internal class CiudadM
    {
        private int id;
        private int nombre;
        private String pais;


        public int Id { get => id; set => id = value; }
        public int Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
    }

}
