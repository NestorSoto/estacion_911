using estacion_911.Controlador;
using System;
using System.Windows.Forms;

namespace estacion_911
{
    public partial class RegistrarPasajero : Form
    {
        public RegistrarPasajero()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(c_codigo.Text);
            String nombre = c_cnombres.Text;
            String apellido = c_apellidos.Text;
            String dni = c_dni.Text;
            String email = c_correo.Text;
            String adulto = c_adulto.Text;
            Boolean es;
            if (adulto == "si")
            {
                es = true;
            }
            else
            {
                es = false;

            }
            EmpleadoM.registrarPasajero(codigo, nombre, apellido, dni, email, es);
            MessageBox.Show("registro terminado");
        }
    }
}
