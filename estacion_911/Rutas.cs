using estacion_911.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
