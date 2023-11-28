using CapaEntidades;
using CapaEntidades.ClasesHijas;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //TipoHabitacion tipo1 = new TipoHabitacion();
            //tipo1.Descripcion = "Tipo 1";
            //tipo1.Precio = 200000;

            //TipoHabitacion tipo2 = new TipoHabitacion();
            //tipo2.Descripcion = "Tipo 2";
            //tipo2.Precio = 150000;

            //TipoHabitacion tipo3 = new TipoHabitacion();
            //tipo3.Descripcion = "Tipo 3";
            //tipo3.Precio = 100000;


            //TipoHabitacionGestion gestion = new TipoHabitacionGestion();
            //gestion.guardar(tipo1);
            //gestion.guardar(tipo2);
            //gestion.guardar(tipo3);

            //UsuarioGestion usuarioGestion = new UsuarioGestion();
            //Usuario usuario = new Usuario();
            //usuario.username = "admin";
            //usuario.password = "admin123";
            //usuarioGestion.guardar(usuario);




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
