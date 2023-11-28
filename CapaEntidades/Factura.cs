using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.ClasesHijas
{
    public class Factura
    {
        public decimal IdFactura { get; set; }
        public decimal IdCliente { get; set; }
        public decimal NumeroReserva { get; set; }
        public string Estado { get; set; } = "Activa";
        public DateTime FechaFacturacion { get; set; } = DateTime.Now;
        public decimal TotalCuenta { get; set; } = 0; //SE CALCULA AUTOMATICAMENTE POR UN PROCEDIMIENTO ALMACENADO

        public Factura()
        {

        }
    }
}
