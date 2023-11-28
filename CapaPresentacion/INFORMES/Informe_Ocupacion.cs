using CapaEntidades.ClasesHijas;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.INFORMES
{
    public partial class Informe_Ocupacion : Form
    {
        public Informe_Ocupacion()
        {
            InitializeComponent();
            PintarReporte();
        }

        private void btnVolverInformeOcupacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        public void PintarReporte()
        {
            ReservacionGestion gestionReserva= new ReservacionGestion();
            HabitacionGestion gestion= new HabitacionGestion();
            foreach (Habitacion habitacion in gestion.lista)
            {

                decimal idHabitacion = habitacion.IdHabitacion;
                string respuesta=gestionReserva.ValidarHabitacion(idHabitacion);    
                tabla.Rows.Add(habitacion.NumeroHabitacion, respuesta);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgInformeOcupacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
   
}
