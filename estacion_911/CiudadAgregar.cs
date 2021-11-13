using estacion_911.Controlador;
using System;
using System.Windows.Forms;

namespace estacion_911
{
    public partial class CiudadAgregar : Form
    {
        public CiudadAgregar()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            String ciudad = c_ciudad.Text;
            String pais = c_pais.Text;
            Administrador.registrarCiudad(ciudad, pais);
            MessageBox.Show("Registro terminado");
        }
    }
}
