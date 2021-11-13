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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TablaPasajero.DataSource = Administrador.MostrarRutas();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RegistrarPasajero rps = new RegistrarPasajero();
            rps.ShowDialog();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            TablaPasajero.DataSource = Administrador.MostrarRutas();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
