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

namespace CapaPresentacion.GUI___FACTURACIONES
{
    public partial class Gestionar_Factura : Form
    {
        FacturaGestion facturaGestion = new FacturaGestion();
        FacturaDetalleGestion detalleGestion = new FacturaDetalleGestion();
        ReservacionGestion reservacionGestion = new ReservacionGestion();
        ProductoGestion productoGestion = new ProductoGestion();
        public Gestionar_Factura()
        {
            InitializeComponent();
            PintarReservas();
            txtValorReserva.Text = $"$0";
        }
        public void PintarReservas()
        {

            foreach (Reservacion res in reservacionGestion.lista)
            {
                if (res.Estado == "Activo")
                {
                    txtNumReserva.Items.Add(res.NumeroReserva);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNumReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarFactura();
        }

        public void BuscarFactura()
        {
            string busqueda = txtNumReserva.Text;
            if (busqueda != "")
            {
                Reservacion reservacion = reservacionGestion.buscar(decimal.Parse(busqueda));
                Factura factura = facturaGestion.buscarPorReserva(decimal.Parse(busqueda));
                if (factura != null)
                {
                    decimal valorReser = obtenerValorReserva(reservacion.IdHabitacion);
                    txtValorReserva.Text = $"${valorReser}";
                    txtFecha.Value = factura.FechaFacturacion;
                    ClienteGestion clienteGestion = new ClienteGestion();
                    Cliente cliente = clienteGestion.buscar(factura.IdCliente);
                    txtInfoCliente.Text = cliente.Nombre + " " + cliente.Apellido + $"({cliente.Cedula})";
                    tabla.Rows.Clear();
                    foreach (FacturaDetalle detalle in detalleGestion.lista)
                    {
                        if (detalle.IdFactura == factura.IdFactura)
                        {
                            Producto producto = productoGestion.buscar(detalle.IdProducto);
                            tabla.Rows.Add(detalle.IdProducto, producto.Nombre, producto.Precio, detalle.CantidadProducto, detalle.Valor);
                        }
                    }
                    labelEstado.Text = "Estado: " + factura.Estado;
                }
                else
                {
                    MessageBox.Show("No existe una factura asociada a esta reserva");
                }
                refrescarTotal();

            }
            else
            {
                txtInfoCliente.Text = "";
            }
        }



        private decimal obtenerValorReserva(decimal idHab)
        {
            HabitacionGestion habitacionGestion = new HabitacionGestion();
            Habitacion hab = habitacionGestion.buscar(idHab);
            TipoHabitacionGestion tipoHabitacionGestion = new TipoHabitacionGestion();
            TipoHabitacion tip = tipoHabitacionGestion.buscar(hab.IdTipoHabitacion);
            return tip.Precio;
        }

        public void refrescarTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in tabla.Rows)
            {
                string dato = fila.Cells[4].Value.ToString();
                decimal subtotal = decimal.Parse(dato);
                total += subtotal;
            }

            string valorSinSignoPeso = txtValorReserva.Text.Split('$')[1];
            decimal valorRes = decimal.Parse(valorSinSignoPeso);

            total += valorRes;
            txtTotalVenta.Text = $"${total}";

        }

        private void btnVolverFacturacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnularFactura_Click(object sender, EventArgs e)
        {
            string numReserva = txtNumReserva.Text;
            if (numReserva == "")
            {
                MessageBox.Show("Debe seleccionar una reservación valida para anulación");
                return;
            }
            var confirmResult = MessageBox.Show("¿Seguro que desea anular esta factura?",
                                     "Confirmar anulación",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Factura factura = facturaGestion.buscarPorReserva(decimal.Parse(numReserva));
                string res = facturaGestion.anular(factura.IdFactura);
                MessageBox.Show(res);
                BuscarFactura();
            }
        }
    }
}
