using CapaDatos;
using CapaEntidades;
using System.Collections.Generic;

namespace CapaLogica
{
    public class FacturaDetalleGestion
    {
        public List<FacturaDetalle> lista;

        FacturaDetalleDatos datos = new FacturaDetalleDatos();

        public FacturaDetalleGestion(){ this.lista = datos.leer(); }

        public string guardar(FacturaDetalle facturaDetalles)
        {
            datos.guardar(facturaDetalles);
            return "Factura almacenada exitosamente";
        }

        public FacturaDetalle buscar(long IdFacturaDetalle)
        {
            this.lista = datos.leer();
            foreach (FacturaDetalle facturaDetalle in lista)
            {
                if (facturaDetalle.IdFacturaDetalle.Equals(IdFacturaDetalle))
                {
                    return facturaDetalle;
                }
            }
            return null;
        }

        public string eliminar(long IdFacturaDetalle)
        {
            FacturaDetalle facturaDetalle = buscar(IdFacturaDetalle);
            if(facturaDetalle == null)
            {
                return "No se encontro la factura con esta identificacion";
            }
            datos.eliminar(IdFacturaDetalle);
            return "Eliminada exitosamente";            
        }
    }

}

