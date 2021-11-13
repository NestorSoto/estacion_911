using estacion_911.Controlador;
using System;
using System.Windows.Forms;

namespace estacion_911
{
    public partial class AvionRegistrar : Form
    {
        public AvionRegistrar()
        {
            InitializeComponent();
        }

        private void btn_registrarAvion_Click(object sender, EventArgs e)
        {
            String marca = c_marca.Text;
            String modelo = c_modelo.Text;
            int capacidad = int.Parse(c_capacidad.Text);
            Administrador.registrar(marca, modelo, capacidad);
            MessageBox.Show("Registro exitoso");

        }
    }
}
