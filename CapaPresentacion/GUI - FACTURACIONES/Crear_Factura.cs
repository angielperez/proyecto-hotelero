using CapaEntidades;
using CapaEntidades.ClasesHijas;
using CapaEntidades.ClasesPadres;
using CapaLogica;
using CapaPresentacion.GUI___PRODUCTOS;
using System;
using System.Collections;
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
    public partial class Crear_Factura : Form
    {
        ReservacionGestion reservacionGestion = new ReservacionGestion();
        ProductoGestion productoGestion = new ProductoGestion();
        FacturaGestion facturaGestion = new FacturaGestion();
        public Crear_Factura()
        {
            InitializeComponent();
            PintarReservas();
            PintarProductos();
            txtValorReserva.Text = $"$0";
        }

        public void PintarReservas()
        {
            
            foreach (Reservacion res in reservacionGestion.lista)
            {
                if (res.Estado == "Activo")
                {
                    Factura factura = facturaGestion.buscarPorReserva(res.NumeroReserva);
                    if (factura == null)
                    {
                        txtNumReserva.Items.Add(res.NumeroReserva);
                    }
                    else
                    {
                        if (factura.Estado == "Anulada")
                        {
                            txtNumReserva.Items.Add(res.NumeroReserva);
                        }
                    }
                }
            }
        }

        public void PintarProductos()
        {
            foreach (Producto pro in productoGestion.lista)
            {
                txtProductos.Items.Add(pro.Nombre);
            }
        }


        private void btnVolverFacturacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNumReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            string busqueda = txtNumReserva.Text;
            if(busqueda != "")
            {
                Reservacion reservacion = reservacionGestion.buscar(int.Parse(busqueda));
                decimal valorReser = obtenerValorReserva(reservacion.IdHabitacion);
                txtValorReserva.Text = $"${valorReser}";
                ClienteGestion clienteGestion = new ClienteGestion();
                Cliente cliente = clienteGestion.buscar(reservacion.IdCliente);
                txtInfoCliente.Text = cliente.Nombre + " " + cliente.Apellido + $"({cliente.Cedula})";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string nomProducto = txtProductos.Text;
            string cantidad = txtCantidad.Text;
            if(nomProducto == "")
            {
                MessageBox.Show("Debe elegir un producto valido");
                return;
            }
            if (cantidad == "")
            {
                MessageBox.Show("Debe elegir una cantidad valida");
                return;
            }
            Producto producto = productoGestion.buscarPorNombre(nomProducto);
            if(producto == null)
            {
                MessageBox.Show("El producto seleccionado no existe");
                return;
            }
            decimal cantidadDetalle = decimal.Parse(cantidad);
            decimal total = producto.Precio * cantidadDetalle;

            bool productoNuevo = true;
            foreach (DataGridViewRow fila in tabla.Rows)
            {
                string id = fila.Cells[0].Value.ToString();
                if (producto.IdProducto.Equals(int.Parse(id)))
                {
                    productoNuevo = false;
                    int cantidadAntes = int.Parse(fila.Cells[3].Value.ToString());
                    cantidadDetalle += cantidadAntes;
                    fila.Cells[3].Value = cantidadDetalle;
                    fila.Cells[4].Value = cantidadDetalle * producto.Precio;
                }
            }
            if (productoNuevo)
            {
                tabla.Rows.Add(producto.IdProducto, producto.Nombre, producto.Precio, cantidadDetalle, total);
            }
            refrescarTotal();
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

        private void button2_Click(object sender, EventArgs e)
        {
            int seleccionadas = tabla.SelectedRows.Count;
            if(seleccionadas > 0)
            {
                foreach (DataGridViewRow item in tabla.SelectedRows)
                {
                    tabla.Rows.RemoveAt(item.Index);
                }
                refrescarTotal();
            }
            else
            {
                MessageBox.Show("Debe escoger por lo menos un producto para eliminar");
            }
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            string numReserva = txtNumReserva.Text;
            if (numReserva == "")
            {
                MessageBox.Show("Debe seleccionar una reservación valida para facturacion");
                return;
            }

            //SE VALIDA LA DISPONIBILIDAD DEL STOCK DE LOS PRODUCTOS
            foreach (DataGridViewRow fila in tabla.Rows)
            {

                string idProd = fila.Cells[0].Value.ToString();
                decimal idProducto = decimal.Parse(idProd);
                string can = fila.Cells[3].Value.ToString();
                decimal cantidadDescontar = decimal.Parse(can);
                Producto producto = productoGestion.buscar(idProducto);
                if (producto.Cantidad - cantidadDescontar < 0)
                {
                    MessageBox.Show("El producto "+producto.Nombre+ " no tiene la cantidad requerida para la factura, la cantidad actual del producto es de: " + producto.Cantidad);
                    return;
                }
            }

            Reservacion reservacion = reservacionGestion.buscar(decimal.Parse(numReserva));
            Factura factura = new Factura();
            factura.NumeroReserva = decimal.Parse(numReserva);
            factura.IdCliente = reservacion.IdCliente;

            FacturaGestion facturaGestion = new FacturaGestion();
            decimal idFactura = facturaGestion.guardar(factura);

            FacturaDetalleGestion detalleGestion = new FacturaDetalleGestion();

            

            foreach (DataGridViewRow fila in tabla.Rows)
            {
                FacturaDetalle detalle = new FacturaDetalle();

                string idProd = fila.Cells[0].Value.ToString();
                decimal idProducto = decimal.Parse(idProd);

                detalle.IdFactura = idFactura;
                detalle.IdProducto = idProducto;
                detalle.PrecioProducto = decimal.Parse(fila.Cells[2].Value.ToString());
                detalle.CantidadProducto = decimal.Parse(fila.Cells[3].Value.ToString());
                detalle.Valor = decimal.Parse(fila.Cells[4].Value.ToString());

                detalleGestion.guardar(detalle);

                Producto producto = productoGestion.buscar(idProducto);
                producto.Cantidad = producto.Cantidad - detalle.CantidadProducto;
                productoGestion.actualizar(producto.Codigo, producto);
            }
            facturaGestion.finalizarFactura(idFactura);
            MessageBox.Show($"La factura con numero [{idFactura}], se regstro exitosamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Crear_Productos form = new Crear_Productos();
            form.ShowDialog();
        }
       

            }
}
