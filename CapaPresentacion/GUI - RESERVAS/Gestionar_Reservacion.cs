using CapaEntidades;
using CapaEntidades.ClasesHijas;
using CapaEntidades.ClasesPadres;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion.GUI___RESERVAS
{
    public partial class Gestionar_Reservacion : Form
    {
        public Gestionar_Reservacion()
        {
            InitializeComponent();
            LlenarHabitaciones();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LlenarHabitaciones()
        {
            HabitacionGestion gestion = new HabitacionGestion();
            List<Habitacion> lista = gestion.lista;
            foreach (var item in lista)
            {
                txtNumHabitacion.Items.Add(item.NumeroHabitacion);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Esta seguro de cancelar esta reserva?", "Cancelacion", MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {

                string numReservaStr = txtNumReservacion.Text;
                if (numReservaStr == "")
                {
                    MessageBox.Show("Debe ingresar el numero de reserva");
                    return;
                }
                long numReserva = Convert.ToInt64(numReservaStr);
                ReservacionGestion gestion = new ReservacionGestion();
                Reservacion reservacion = gestion.buscar(numReserva);
                if (reservacion == null)
                {
                    MessageBox.Show("La reservacion no existe");
                    return;
                }

                if (reservacion.Estado == "Cancelada")
                {
                    MessageBox.Show("La reservacion no se pude modificar ya que se encuentra cancelada");
                    return;
                }
                reservacion.Estado = "Cancelada";
                string mensaje = gestion.actualizar(numReserva, reservacion);
                MessageBox.Show("Cancelacion exitosa");
                Consultar();
            }
        }

        public void Consultar()
        {
            string numReservaStr = txtNumReservacion.Text;
            if (numReservaStr == "")
            {
                MessageBox.Show("Debe ingresar el numero de reserva");
                return;
            }
            long numReserva = Convert.ToInt64(numReservaStr);
            ReservacionGestion gestion = new ReservacionGestion();
            Reservacion reservacion = gestion.buscar(numReserva);
            if (reservacion == null)
            {
                MessageBox.Show("La reservacion no existe");
                return;
            }
            decimal idCliente = reservacion.IdCliente;

            ClienteGestion clienteGestion = new ClienteGestion();
            Cliente cliente = clienteGestion.buscar(idCliente);

            txtConsultarNom.Text = cliente.Nombre;
            txtConsultarApell.Text = cliente.Apellido;
            txtConsultarCedu.Text = cliente.Cedula;
            txtConsultarCorreo.Text = cliente.Correo;
            txtConsultarTel.Text = cliente.Telefono;

            HabitacionGestion habitacionGestion = new HabitacionGestion();
            Habitacion habitacion = habitacionGestion.buscar(reservacion.IdHabitacion);

            txtNumHabitacion.Text = habitacion.NumeroHabitacion.ToString();
            txtConsultarNumAdultos.Text = reservacion.NumeroAdultos.ToString();
            txtConsultarNumNinos.Text = reservacion.NumeroNiños.ToString();
            dtpConsultarEntrada.Value = reservacion.FechaInicio;
            dtpConsultarSalida.Value = reservacion.FechaFin;

            TipoHabitacionGestion tipoHabitacionGestion = new TipoHabitacionGestion();
            TipoHabitacion tipoHabitacion = tipoHabitacionGestion.buscar(habitacion.IdTipoHabitacion);
            labelValor.Text = "TOTAL A PAGAR: $" + tipoHabitacion.Precio.ToString();
            labelEstado.Text = "ESTADO: " + reservacion.Estado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numReservaStr = txtNumReservacion.Text;
            if (numReservaStr == "")
            {
                MessageBox.Show("Debe ingresar el numero de reserva");
                return;
            }
            long numReserva = Convert.ToInt64(numReservaStr);
            ReservacionGestion gestion = new ReservacionGestion();
            Reservacion reservacion = gestion.buscar(numReserva);
            if (reservacion == null)
            {
                MessageBox.Show("La reservacion no existe");
                return;
            }

            if(reservacion.Estado == "Cancelada")
            {
                MessageBox.Show("La reservacion no se pude modificar ya que se encuentra cancelada");
                return;
            }

            //AHORA SE HACE PRACTICAMENTE LO MISMO Q EN EL CREAR


            string nombre = txtConsultarNom.Text;
            string apellido = txtConsultarApell.Text;
            string telefono = txtConsultarTel.Text;
            string cedula = txtConsultarCedu.Text;
            string correo = txtConsultarCorreo.Text;
            string numHabitacionStr = txtNumHabitacion.Text;
            string numAdultosstr = txtConsultarNumAdultos.Text;
            string numNiñosstr = txtConsultarNumNinos.Text;
            string fechaIniciostr = dtpConsultarEntrada.Text;
            string fechaFinstr = dtpConsultarSalida.Text;

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

            HabitacionGestion habitacionGestion = new HabitacionGestion();
            Habitacion habitacion = habitacionGestion.buscarPorNumHab(numHabitacion);

            if (habitacion == null)
            {
                MessageBox.Show("El numero de la habitacion no esta registrado");
                return;
            }

            decimal idHabitacion = habitacion.IdHabitacion;

            DateTime fechaInicio = dtpConsultarEntrada.Value;
            DateTime fechaFin = dtpConsultarSalida.Value;

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
            

            reservacion.IdCliente = IdPersona;
            reservacion.IdHabitacion = idHabitacion;
            reservacion.NumeroAdultos = numAdultos;
            reservacion.NumeroNiños = numNiños;
            reservacion.FechaInicio = fechaInicio;
            reservacion.FechaFin = fechaFin;

            ReservacionGestion reservacionGestion = new ReservacionGestion();
            string mensaje = reservacionGestion.actualizar(numReserva, reservacion);
            MessageBox.Show(mensaje);

            Consultar();
        }
    }
}
