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
    public partial class AvionEliminar : Form
    {
        public AvionEliminar()
        {
            InitializeComponent();
        }

        private void btn_eliminarAvion_Click(object sender, EventArgs e)
        {
            String marca = c_marca.Text;
            String modelo = c_modelo.Text;
            Administrador.eliminarAvion(marca, modelo);
            MessageBox.Show("Eliminacion terminada");
        }
    }
}
