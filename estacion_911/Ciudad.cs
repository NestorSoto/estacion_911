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
    public partial class Ciudad : Form
    {
        public Ciudad()
        {
            InitializeComponent();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            tablaCiudades.DataSource= Administrador.MostrarCiudades();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CiudadEliminar c = new CiudadEliminar();
            c.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            CiudadAgregar c = new CiudadAgregar();
            c.ShowDialog();
        }

        private void Ciudad_Load(object sender, EventArgs e)
        {
            tablaCiudades.DataSource = Administrador.MostrarCiudades();
        }
    }
}
