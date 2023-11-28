using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class TipoHabitacion
    {
        public decimal IdTipoHabitacion { get; set; }
        public decimal IdHotel { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
    }
}
