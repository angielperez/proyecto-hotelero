using CapaEntidades;
using CapaEntidades.ClasesHijas;
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

namespace CapaPresentacion.GUI___HABITACIONES
{
    public partial class Gestionar_Habitacion : Form
    {
        public Gestionar_Habitacion()
        {
            InitializeComponent();
            LlenarTiposHabitaciones();
        }

        public void LlenarTiposHabitaciones()
        {
            TipoHabitacionGestion gestion = new TipoHabitacionGestion();
            List<TipoHabitacion> lista = gestion.lista;
            foreach (var item in lista)
            {
                listaTipoHabitacion.Items.Add(item.Descripcion);
            }
        }

        private void btnVolverConsultaHabitacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarHabitacion_Click(object sender, EventArgs e)
        {
            string num = txtNumHabitacion.Value.ToString();
            if (num == "")
            {
                MessageBox.Show("Porfavor digite un numero de habitacion valido");
                return;
            }

            int numHabitacion = int.Parse(num);

            HabitacionGestion gestion = new HabitacionGestion();
            Habitacion respuesta = gestion.buscarPorNumHab(numHabitacion);
            if (respuesta == null)
            {
                MessageBox.Show("El numero de habitacion no existe");
                return;
            }

            decimal idTipoHabitacion = respuesta.IdTipoHabitacion;
            TipoHabitacionGestion gestionTipo = new TipoHabitacionGestion();
            TipoHabitacion respTipoHabitacion = gestionTipo.buscar(idTipoHabitacion);

            decimal precio = respTipoHabitacion.Precio;

            listaTipoHabitacion.Text = respTipoHabitacion.Descripcion;
            listaEstado.Text = respuesta.Estado;
            txtDescripcion.Text = respuesta.Descripcion;

            labelPrecio.Text = "Precio: " + precio.ToString(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numHabitacionStr = txtNumHabitacion.Text;
            string tipoHabitacionStr = listaTipoHabitacion.Text;
            string estado = listaEstado.Text;
            string descripcion = txtDescripcion.Text;
            TipoHabitacionGestion gestionTipo = new TipoHabitacionGestion();
            TipoHabitacion tipoHabitacion = gestionTipo.buscarPorDesc(tipoHabitacionStr);
            if (tipoHabitacion == null)
            {
                MessageBox.Show("El tipo de habitacion no es valido");
                return;
            }

            if (numHabitacionStr == "")
            {
                MessageBox.Show("Porfavor digite un numero de habitacion valido");
                return;
            }

            decimal idTipoHabitacion = tipoHabitacion.IdTipoHabitacion;
            HabitacionGestion habitacionGestion = new HabitacionGestion();

            int num = int.Parse(numHabitacionStr);
            Habitacion habitacion = habitacionGestion.buscarPorNumHab(num);

            if(habitacion == null)
            {
                MessageBox.Show("La habitacion no existe para ser actualizada");
                return;
            }

            habitacion.NumeroHabitacion = num;
            habitacion.Descripcion = descripcion;
            habitacion.IdTipoHabitacion = idTipoHabitacion;
            habitacion.Estado = estado;
            habitacion.IdHotel = 1;

            
            string mensaje = habitacionGestion.actualizar(habitacion.IdHabitacion, habitacion);
            MessageBox.Show(mensaje);
        }
    }
}
