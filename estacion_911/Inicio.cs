using System;
using System.Windows.Forms;

namespace estacion_911
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            c_login.Text = userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String v=c_login.get;

            AdministradorF a = new AdministradorF();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }





        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String user = c_login.Text;
            MessageBox.Show("hola " + user);
            AdministradorF a = new AdministradorF();
            a.ShowDialog();
        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.ShowDialog();

        }


    }
}
