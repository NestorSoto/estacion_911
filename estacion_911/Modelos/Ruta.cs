using System;

namespace estacion_911.Modelos
{
    internal class Ruta
    {
        int Codigo;
        String destino;
        String fechaSalida;
        String fechaLlegada;
        String origenCiudad;
        String origenPais;
        String destinoCiudad;
        String destinoPais;

        public string FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public int Codigo1 { get => Codigo; set => Codigo = value; }
        public string Destino { get => destino; set => destino = value; }
        public string FechaLlegada { get => fechaLlegada; set => fechaLlegada = value; }
        public string OrigenCiudad { get => origenCiudad; set => origenCiudad = value; }
        public string OrigenPais { get => origenPais; set => origenPais = value; }
        public string DestinoCiudad { get => destinoCiudad; set => destinoCiudad = value; }
        public string DestinoPais { get => destinoPais; set => destinoPais = value; }
    }
}
