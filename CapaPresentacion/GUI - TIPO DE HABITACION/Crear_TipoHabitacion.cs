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

namespace CapaPresentacion.GUI___TIPO_DE_HABITACION
{
    public partial class Crear_TipoHabitacion : Form
    {
        public Crear_TipoHabitacion()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverCrearHabitacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnGuardarTipoHabitacion_Click_1(object sender, EventArgs e)
        {
            string descripcion = txtDescripcionTipoHabitacion.Text;
            string precio = txtPrecio.Text;

            TipoHabitacionGestion gestionTipo = new TipoHabitacionGestion();
            TipoHabitacion tipoHabitacion = gestionTipo.buscarPorDesc(descripcion);
            if (descripcion == null)
            {
                MessageBox.Show("El tipo de habitacion no es valido");
                return;
            }


           

            tipoHabitacion.Descripcion = descripcion;
            tipoHabitacion.Precio = int.Parse(precio);


            TipoHabitacionGestion tipoHabitacionGestion = new TipoHabitacionGestion();
            string mensaje = tipoHabitacionGestion.guardar(tipoHabitacion);
            MessageBox.Show(mensaje);
        }

        private void btnGuardarTipoHabitacion_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcionTipoHabitacion.Text;
            string precio = txtPrecio.Text;

            TipoHabitacionGestion gestionTipo = new TipoHabitacionGestion();
            TipoHabitacion tipoHabitacion = gestionTipo.buscarPorDesc(descripcion);
            if (tipoHabitacion != null)
            {
                MessageBox.Show("La descripcion del tipo de habitacion ya esta registrada");
                return;
            }

            tipoHabitacion=new TipoHabitacion();        

            tipoHabitacion.Descripcion = descripcion;
            tipoHabitacion.Precio = int.Parse(precio);
            tipoHabitacion.IdHotel = 1; 


            string mensaje = gestionTipo.guardar(tipoHabitacion);
            MessageBox.Show(mensaje);
        }

            }
}

   


