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
    public partial class CiudadEliminar : Form
    {
        public CiudadEliminar()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            String ciudad= c_ciudad.Text;
            String pais= c_pais.Text;
            Administrador.EliminarCiudad(ciudad, pais);
            MessageBox.Show("Ciudad Eliminada");
        }
    }
}
