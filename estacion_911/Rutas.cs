using estacion_911.Controlador;
using System;
using System.Windows.Forms;

namespace estacion_911
{
    public partial class Rutas : Form
    {
        public Rutas()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            tabla_rutas.DataSource = Administrador.MostrarRutas();
        }

        private void Rutas_Load(object sender, EventArgs e)
        {
            tabla_rutas.DataSource = Administrador.MostrarRutas();
        }
    }
}
