using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class FacturaDetalle
    {
        public decimal IdFacturaDetalle { get; set; }
        public decimal IdFactura { get; set; }
        public decimal IdProducto { get; set; }
        public decimal CantidadProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public decimal Valor { get; set; }

    }
}
