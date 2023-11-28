using CapaEntidades;
using CapaEntidades.ClasesHijas;
using CapaEntidades.ClasesPadres;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.INFORMES
{
    public partial class Informe_Reserva : Form
    {
        public Informe_Reserva()
        {
            InitializeComponent();
        }

        private void dtgInformeFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultarFactura_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;

            ReservacionGestion reservacionGestion = new ReservacionGestion();
            ClienteGestion clienteGestion = new ClienteGestion();
            HabitacionGestion habitacionGestion = new HabitacionGestion();
            TipoHabitacionGestion tipoHabitacionGestion = new TipoHabitacionGestion();
            tabla.Rows.Clear();
            foreach (Reservacion reserva in reservacionGestion.lista)
            {
                if(fechaInicio <= reserva.FechaInicio && fechaFin >= reserva.FechaInicio)
                {
                    decimal numReserva = reserva.NumeroReserva;

                    Cliente cliente = clienteGestion.buscar(reserva.IdCliente);
                    string titular = cliente.Nombre + " " + cliente.Apellido + " - " + cliente.Cedula;

                    Habitacion habitacion = habitacionGestion.buscar(reserva.IdHabitacion);
                    decimal numHabitacion = habitacion.NumeroHabitacion;

                    TipoHabitacion tipoHabitacion = tipoHabitacionGestion.buscar(habitacion.IdTipoHabitacion);
                    decimal valor = tipoHabitacion.Precio;

                    string fechaI = reserva.FechaInicio.ToShortDateString() + " " + reserva.FechaInicio.ToShortTimeString();
                    string fechaF = reserva.FechaFin.ToShortDateString() + " " + reserva.FechaFin.ToShortTimeString();

                    string estado = reserva.Estado;

                    tabla.Rows.Add(numReserva, titular, "$"+ valor, fechaI, fechaF, numHabitacion, estado);
                }
            }
        }

        private void btnVolverInformeFacturacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
