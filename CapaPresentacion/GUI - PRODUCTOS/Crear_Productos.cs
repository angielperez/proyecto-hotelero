using CapaEntidades.ClasesHijas;
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

namespace CapaPresentacion.GUI___PRODUCTOS
{
    public partial class Crear_Productos : Form
    {
        public Crear_Productos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolverCrearProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombreProducto.Text;
            string cantidad = txtCantidad.Text;
            string precio = txtPrecio.Text;
            string descripcion = txtDescripcion.Text;
           
            if (codigo == "")
            {
                MessageBox.Show("El codigo no es valido");
                return;
            }

            if (nombre == "")
            {
                MessageBox.Show("El nombre no es valido");
                return;
            }

            if (cantidad == "")
            {
                MessageBox.Show("La cantidad no es valido");
                return;
            }

            if (precio == "")
            {
                MessageBox.Show("El precio no es valido");
                return;
            }

            if (descripcion == "")
            {
                MessageBox.Show("La descripcion no es valido");
                return;
            }

            ProductoGestion gestion = new ProductoGestion();
            bool respueta = gestion.ValidarCodigoExiste(codigo);
            if (respueta == true)
            {
                MessageBox.Show("El codigo ya existe");
                return;
            }
            


            Producto producto = new Producto();

            producto.Codigo = codigo;
            producto.Nombre = nombre;
            producto.Cantidad = int.Parse(cantidad);
            producto.Precio = decimal.Parse(precio);
            producto.Descripcion = descripcion;
            producto.IdHotel = 1;

            ProductoGestion productoGestion = new ProductoGestion();
            string mensaje = productoGestion.guardar(producto);
            MessageBox.Show(mensaje);
        }

      
    }
    }

