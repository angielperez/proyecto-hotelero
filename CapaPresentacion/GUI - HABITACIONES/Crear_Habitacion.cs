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
    public partial class Crear_Habitacion : Form
    {

        public Crear_Habitacion()
        {
            InitializeComponent();
            LlenarTiposHabitaciones();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverCrearHabitacion_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnGuardarHabitacion_Click(object sender, EventArgs e)
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

            decimal idTipoHabitacion = tipoHabitacion.IdTipoHabitacion;

            Habitacion habitacion = new Habitacion();

            habitacion.NumeroHabitacion = int.Parse(numHabitacionStr);
            habitacion.Descripcion = descripcion;
            habitacion.IdTipoHabitacion = idTipoHabitacion;
            habitacion.Estado = estado;
            habitacion.IdHotel = 1;

            HabitacionGestion habitacionGestion = new HabitacionGestion();
            string mensaje = habitacionGestion.guardar(habitacion);
            MessageBox.Show(mensaje);
        }

       
    }
}
