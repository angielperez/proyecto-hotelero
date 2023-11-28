using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.ClasesHijas
{
    public class Habitacion
    {
        public decimal IdHabitacion { get; set; } 
        public decimal IdHotel { get; set; }
        public decimal IdTipoHabitacion { get; set; }
        public decimal NumeroHabitacion { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; } = "Activa";
    }
}
