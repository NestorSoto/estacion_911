using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estacion_911
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool log = login();
            if (log)
            {
                MessageBox.Show("Usuario administrador");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Inicio());

            }
            else
            {
                MessageBox.Show("Usuario no administrador");
                Empleado e=new Empleado();
                e.ShowDialog();
            }
            
            
        }

        static Boolean login()
        {


            using (var user = WindowsIdentity.GetCurrent())
            {
                var principal = new WindowsPrincipal(user);
                // Check for token claim with well-known Administrators group SID
                const string LOCAL_ADMININSTRATORS_GROUP_SID = "S-1-5-32-544";
                if (principal.Claims.SingleOrDefault(x => x.Value == LOCAL_ADMININSTRATORS_GROUP_SID) != null)
                {
                    
                    return true;

                }
                else
                {
                    
                    return false;
                }
            }
        }
    }
}
