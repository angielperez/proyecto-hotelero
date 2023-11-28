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

namespace CapaPresentacion.GUI___RESERVAS
{
    public partial class Crear_Reservacion : Form
    {
        public Crear_Reservacion()
        {
            InitializeComponent();
            LlenarHabitaciones();
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        public void LlenarHabitaciones()
        {
            HabitacionGestion gestion = new HabitacionGestion();
            ReservacionGestion reservacionGestion = new ReservacionGestion();       
            List<Habitacion> lista = gestion.lista;
            foreach (var item in lista)
            {
                if (reservacionGestion.ValidarHabitacion(item.IdHabitacion).Equals("Libre"))
                {
                    listaHabitaciones.Items.Add(item.NumeroHabitacion);
                }
                
            }
        }

        private void btnGuardarReserva_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreReservacion.Text;
            string apellido = txtApellidoReservacion.Text;
            string telefono = txtTelReservacion.Text;
            string cedula = txtCedulaReservacion.Text;
            string correo = txtCorreoReservacion.Text;
            string numHabitacionStr = listaHabitaciones.Text;
            string numAdultosstr = txtNumAdultos.Text;
            string numNiñosstr = txtNumNiños.Text;
            string fechaIniciostr = txtFechaInicio.Text;
            string fechaFinstr = txtFechaFin.Text;

            if (nombre == "")
            {
                MessageBox.Show("El nombre es un campo obligatorio");
                return;
            }
            if (apellido == "")
            {
                MessageBox.Show("El apellido es un campo obligatorio");
                return;
            }
            if (telefono == "")
            {
                MessageBox.Show("El telefono es un campo obligatorio");
                return;
            }
            if (cedula == "")
            {
                MessageBox.Show("La cedula es un campo obligatorio");
                return;
            }
            if (correo == "")
            {
                MessageBox.Show("El correo es un campo obligatorio");
                return;
            }
            if (numHabitacionStr == "")
            {
                MessageBox.Show("El numero de habitacion es un campo obligatorio");
                return;
            }
            if (numAdultosstr == "")
            {
                MessageBox.Show("El numero de adultos es un campo obligatorio");
                return;
            }
            if (numNiñosstr == "")
            {
                MessageBox.Show("El numero de niños es un campo obligatorio");
                return;
            }
            if (fechaIniciostr == "")
            {
                MessageBox.Show("El Checkin es un campo obligatorio");
                return;
            }
            if (fechaFinstr == "")
            {
                MessageBox.Show("La Checkout es un campo obligatorio");
                return;
            }

            int numAdultos = int.Parse(numAdultosstr);
            int numNiños = int.Parse(numNiñosstr);
            int numHabitacion = int.Parse(numHabitacionStr); 

            HabitacionGestion habitacionGestion= new HabitacionGestion();
            Habitacion habitacion= habitacionGestion.buscarPorNumHab(numHabitacion);
            
            if (habitacion == null)
            {
                MessageBox.Show("El numero de la habitacion no esta registrado");
                return;
            }

            decimal idHabitacion = habitacion.IdHabitacion;

            DateTime fechaInicio = txtFechaInicio.Value;
            DateTime fechaFin = txtFechaFin.Value;

            if (fechaFin < fechaInicio)
            {
                MessageBox.Show("La fecha de Checkout no puede ser inferior a la fecha de Checkin");
                return;
            }

            Cliente cliente = new Cliente();
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.Cedula = cedula;
            cliente.Correo = correo;
            cliente.Telefono = telefono;
            cliente.IdHotel = 1;

            ClienteGestion clienteGestion = new ClienteGestion();
            decimal IdPersona = clienteGestion.guardar(cliente); 
            

            Reservacion reservacion= new Reservacion();
            reservacion.IdCliente = IdPersona;
            reservacion.IdHabitacion = idHabitacion;
            reservacion.NumeroAdultos = numAdultos;
            reservacion.NumeroNiños = numNiños; 
            reservacion.FechaInicio= fechaInicio;   
            reservacion.FechaFin= fechaFin;

            ReservacionGestion reservacionGestion = new ReservacionGestion();
            string mensaje = reservacionGestion.guardar(reservacion);

            MessageBox.Show(mensaje);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Crear_Reservacion_Load(object sender, EventArgs e)
        {

        }

        
    }
}
