using estacion_911.Controlador;
using System;
using System.Windows.Forms;

namespace estacion_911
{
    public partial class Aviones : Form
    {
        public Aviones()
        {

            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            panel1.DataSource = Administrador.MostrarAviones();
            //String mensaje = (string)Administrador.MostrarAvionesRegistradosAsync();

        }

        private void panel1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            AvionEliminar ae = new AvionEliminar();
            ae.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AvionRegistrar a = new AvionRegistrar();
            a.ShowDialog();
        }

        private void Aviones_Load(object sender, EventArgs e)
        {
            panel1.DataSource = Administrador.MostrarAviones();
        }
    }
}
