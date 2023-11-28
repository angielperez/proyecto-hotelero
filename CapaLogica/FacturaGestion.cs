using CapaDatos;
using CapaEntidades;
using CapaEntidades.ClasesHijas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class FacturaGestion
    {
        public List<Factura> lista;

        FacturaDatos datos = new FacturaDatos();

        public FacturaGestion()
        {
            this.lista = datos.leer();
        }

        public decimal guardar(Factura factura)
        {
            datos.guardar(factura);
            this.lista = datos.leer();
            return this.lista[0].IdFactura;
        }

        public Factura buscar(decimal IdFactura)
        {
            this.lista = datos.leer();
            foreach (Factura factura in lista)
            {
                if (factura.IdFactura.Equals(IdFactura))
                {
                    return factura;
                }
            }
            return null;
        }

        public Factura buscarPorReserva(decimal NumeroReserva)
        {
            this.lista = datos.leer();
            foreach (Factura factura in lista)
            {
                if (factura.NumeroReserva.Equals(NumeroReserva))
                {
                    return factura;
                }
            }
            return null;
        }

        public string anular(decimal IdFactura)
        {
            Factura factura = buscar(IdFactura);
            if (factura == null)
            {
                return "No se encontro la factura para anulacion";
            }
            datos.anular(IdFactura);
            return "Factura anulada exitosamente";
        }

        public void finalizarFactura(decimal idFactura)
        {
            datos.finalizarFactura(idFactura);
        }
    }

}

