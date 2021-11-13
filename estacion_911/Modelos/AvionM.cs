using System;

namespace estacion_911.Modelos
{
    internal class AvionM
    {
        private int id;
        private int capacidad;
        private String marca;
        private String modelo;

        public int Capacidad { get => capacidad; set => capacidad = value; }
        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
    }

}
