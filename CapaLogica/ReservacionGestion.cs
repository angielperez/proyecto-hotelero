using CapaDatos;
using CapaEntidades;
using CapaEntidades.ClasesHijas;
using CapaEntidades.ClasesPadres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ReservacionGestion
    {
        public List<Reservacion> lista;

        ReservacionDatos datos = new ReservacionDatos();

        public ReservacionGestion(){ this.lista = datos.leer(); }

        public string guardar(Reservacion reservacion)
        {
            datos.guardar(reservacion);
            lista=datos.leer();
            reservacion = lista[0];
            return "Reserva #" + reservacion.NumeroReserva + " almacenada exitosamente";
        }

        public Reservacion buscar(decimal NumeroReserva)
        {
            this.lista = datos.leer();
            foreach (Reservacion reservacion in lista)
            {
                if (reservacion.NumeroReserva.Equals(NumeroReserva))
                {
                    return reservacion;
                }
            }
            return null;
        }

        public string eliminar(long NumeroReserva)
        {
            Reservacion busqueda = buscar(NumeroReserva);
            if (busqueda == null)
            {
                return "No se encontro reserva con esta identificacion";
            }
            datos.eliminar(NumeroReserva);
            return "Eliminada exitosamente";
        }

        public string actualizar(long NumeroReserva, Reservacion nuevaReservacion)
        {
            datos.actualizar(NumeroReserva, nuevaReservacion);
            return "Actualizacion exitosa";
        }

        public String ValidarHabitacion(decimal idHabitacion)
        {
            this.lista = datos.leer();
            DateTime fechaActual = DateTime.Now;    
            foreach (Reservacion reservacion in lista)
            {
                if(reservacion.Estado != "Cancelada")
                {
                    if (reservacion.IdHabitacion.Equals(idHabitacion))
                    {
                        if (reservacion.FechaInicio <= fechaActual && reservacion.FechaFin >= fechaActual)
                        {
                            return "Ocupada";
                        }
                    }
                }
                
            }
            return "Libre";
        }
    }
}

