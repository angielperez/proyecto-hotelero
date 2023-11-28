using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.ClasesPadres
{
    public class Reservacion
    {
        public decimal NumeroReserva { get; set; }
        public decimal IdCliente { get; set; }
        public decimal IdHabitacion { get; set; }
        public decimal NumeroAdultos { get; set; }
        public decimal NumeroNiños { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public string Estado { get; set; } = "Activo";

        public Reservacion()
        {

        }
    }
}
