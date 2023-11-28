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
    public partial class Gestionar_Productos : Form
    {
        public Gestionar_Productos()
        {
            InitializeComponent();
        }

        private void Gestionar_Productos_Load(object sender, EventArgs e)
        {

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

        private void btnConsultarProducto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            if (codigo == "")
            {
                MessageBox.Show("Porfavor digite un codigo valido");
                return;
            }

            
            ProductoGestion gestion = new ProductoGestion();
            Producto respuesta = gestion.buscarPorCodigo(codigo);
            if (respuesta == null)
            {
                MessageBox.Show("El codigo del producto no existe");
                return;
            }

            txtCodigo.Text = respuesta.Codigo;
            txtNombreProducto.Text = respuesta.Nombre;
            txtDescripcion.Text = respuesta.Descripcion;
            txtCantidad.Text = respuesta.Cantidad.ToString();
            txtPrecio.Text = respuesta.Precio.ToString();

        }

        private void btnVolverGestionarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarGestionarProducto_Click(object sender, EventArgs e)
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
            
            Producto producto = gestion.buscarPorCodigo(codigo);
            if (producto == null)
            {
                MessageBox.Show("El codigo del producto no existe");
                return;
            }

            producto.Codigo = codigo;
            producto.Nombre = nombre;
            producto.Cantidad = int.Parse(cantidad);
            producto.Precio = decimal.Parse(precio);
            producto.Descripcion = descripcion;


           
            string mensaje = gestion.actualizar(codigo, producto);
            MessageBox.Show(mensaje);
        }
    }
}
