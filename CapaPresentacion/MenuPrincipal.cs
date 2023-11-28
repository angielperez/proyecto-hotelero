using CapaPresentacion.GUI___FACTURACIONES;
using CapaPresentacion.GUI___HABITACIONES;
using CapaPresentacion.GUI___PRODUCTOS;
using CapaPresentacion.GUI___RESERVAS;
using CapaPresentacion.GUI___TIPO_DE_HABITACION;
using CapaPresentacion.GUI_USUARIOS;
using CapaPresentacion.INFORMES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            if (!pnlReserva.Visible)
            {
                pnlReserva.Visible = true;
            }
            else
            {
                pnlReserva.Visible = false;
            }
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            if (!pnlFacturacion.Visible)
            {
                pnlFacturacion.Visible = true;
            }
            else
            {
                pnlFacturacion.Visible = false;
            }
        }

        private void btnHabitacion_Click(object sender, EventArgs e)
        {
            if (!pnlHabitacion.Visible)
            {
                pnlHabitacion.Visible = true;
            }
            else
            {
                pnlHabitacion.Visible = false;
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (!pnlProductos.Visible)
            {
                pnlProductos.Visible = true;
            }
            else
            {
                pnlProductos.Visible = false;
            }
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            if (!pnlInformes.Visible)
            {
                pnlInformes.Visible = true;
            }
            else
            {
                pnlInformes.Visible = false;
            }
        }

        private void btnCrearReserva_Click(object sender, EventArgs e)
        {
            
            Crear_Reservacion crear_Reservacion = new Crear_Reservacion();
            crear_Reservacion.ShowDialog();
            
        }

        private void btnConsultarReserva_Click(object sender, EventArgs e)
        {
            Gestionar_Reservacion consultar_Reservacion = new Gestionar_Reservacion();
            consultar_Reservacion.ShowDialog();
        }

        private void btnAnularFactura_Click(object sender, EventArgs e)
        {
            Gestionar_Factura anula_Factura = new Gestionar_Factura();
            anula_Factura.ShowDialog();
        }

        private void btnCrearFactura_Click(object sender, EventArgs e)
        {
            Crear_Factura crear_Factura = new Crear_Factura();
            crear_Factura.ShowDialog();
        }

        private void btnConsultarFactura_Click(object sender, EventArgs e)
        {
            Gestionar_Factura form = new Gestionar_Factura();
            form.ShowDialog();
        }

        private void btnCrearHabitacion_Click(object sender, EventArgs e)
        {
            Crear_Habitacion crear_Habitacion = new Crear_Habitacion();
            crear_Habitacion.ShowDialog();
        }

        private void btnConsultarHabitacion_Click(object sender, EventArgs e)
        {
            Gestionar_Habitacion consultar_Habitacion = new Gestionar_Habitacion();
            consultar_Habitacion.ShowDialog();
        }

        private void btnInformeOcupacion_Click(object sender, EventArgs e)
        {
            Informe_Ocupacion informe_Ocupacion = new Informe_Ocupacion();
            informe_Ocupacion.ShowDialog();
        }

        private void btnInformeFacturacion_Click(object sender, EventArgs e)
        {
            Informe_Facturacion informe_Facturacion = new Informe_Facturacion();
            informe_Facturacion.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            Crear_Productos crear_Productos = new Crear_Productos();
            crear_Productos.ShowDialog();
        }

        private void btnConsultarProducto_Click(object sender, EventArgs e)
        {
            Gestionar_Productos consultar_Productos = new Gestionar_Productos();
            consultar_Productos.ShowDialog();
        }

        private void btnInformeReserva_Click(object sender, EventArgs e)
        {
            Informe_Reserva informe_Reserva = new Informe_Reserva();
            informe_Reserva.ShowDialog();
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            if (!pnlTipoHabitacion.Visible)
            {
                pnlTipoHabitacion.Visible = true;
            }
            else
            {
                pnlTipoHabitacion.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (!pnlUsuario.Visible)
            {
                pnlUsuario.Visible = true;
            }
            else
            {
                pnlUsuario.Visible = false;
            }
        }

        private void pnlUsuario_Click(object sender, EventArgs e)
        {
            Crear_Usuario crear_Usuario = new Crear_Usuario();
            crear_Usuario.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestionar_Usuario consultar_Usuario = new Gestionar_Usuario();
            consultar_Usuario.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Crear_TipoHabitacion crear_TipoHabitacion = new Crear_TipoHabitacion();
            crear_TipoHabitacion.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gestionar_TipoHabitacion consultar_TipoHabitacion = new Gestionar_TipoHabitacion();
            consultar_TipoHabitacion.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Informe_Inventario form = new Informe_Inventario();
            form.ShowDialog();
        }
    }
}
