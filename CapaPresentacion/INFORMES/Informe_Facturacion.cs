using CapaEntidades.ClasesHijas;
using CapaEntidades.ClasesPadres;
using CapaEntidades;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion.INFORMES
{
    public partial class Informe_Facturacion : Form
    {
        public Informe_Facturacion()
        {
            InitializeComponent();
        }

        private void btnVolverInformeFacturacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarFactura_Click(object sender, EventArgs e)
        {
            FacturaGestion facturaGestion = new FacturaGestion();
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;
            ClienteGestion clienteGestion = new ClienteGestion();
            tabla.Rows.Clear();
            decimal total = 0;
            foreach (Factura factura in facturaGestion.lista)
            {

                if (fechaInicio <= factura.FechaFacturacion && fechaFin >= factura.FechaFacturacion)
                {

                    Cliente cliente = clienteGestion.buscar(factura.IdCliente);
                    string titular = cliente.Nombre + " " + cliente.Apellido + " - " + cliente.Cedula;
                    string fecha = factura.FechaFacturacion.ToShortDateString() + " " + factura.FechaFacturacion.ToShortTimeString();
                    string estado = factura.Estado;
                    if (factura.Estado != "Anulada")
                    {
                        total += factura.TotalCuenta;
                    }
                    tabla.Rows.Add(fecha, factura.IdFactura, factura.NumeroReserva, titular, estado, "$" + factura.TotalCuenta);
                }
            }

            labelTotal.Text = "Total vendido: $" + total;
        }

        
    }
}