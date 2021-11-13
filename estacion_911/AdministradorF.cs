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
    public partial class AdministradorF : Form
    {
        public AdministradorF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ciudad rs = new Ciudad();
            rs.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Aviones a = new Aviones();
            a.ShowDialog();
        }

        private void btn_rutas_Click(object sender, EventArgs e)
        {
            Rutas r= new Rutas();
            r.ShowDialog();
        }
    }
}
