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
    public partial class Gestionar_TipoHabitacion : Form
    {
        public Gestionar_TipoHabitacion()
        {
            InitializeComponent();
        }

        private void Gestionar_TipoHabitacion_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverCrearHabitacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarTipoHabitacion_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcionTipoHabitacion.Text;
            string precio = txtPrecio.Text;
            
            TipoHabitacionGestion gestionTipo = new TipoHabitacionGestion();
            TipoHabitacion tipoHabitacion = gestionTipo.buscarPorDesc(descripcion);
            if (descripcion == null)
            {
                MessageBox.Show("La descripcion no es valida");
                return;
            }

            if (descripcion == "")
            {
                MessageBox.Show("Porfavor digite un descripcion de habitacion valida");
                return;
            }

            
            TipoHabitacionGestion tipoHabitacionGestion = new TipoHabitacionGestion();

           
            if (descripcion == null)
            {
                MessageBox.Show("La descripcion no existe para ser actualizada");
                return;
            }

            tipoHabitacion.Descripcion = descripcion;
            tipoHabitacion.Precio = decimal.Parse(precio);



            string mensaje = tipoHabitacionGestion.actualizar(tipoHabitacion.IdTipoHabitacion, tipoHabitacion);
            MessageBox.Show(mensaje);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcionTipoHabitacion.Text;
            if (descripcion == "")
            {
                MessageBox.Show("Porfavor digite una descripcion valida");
                return;
            }


            TipoHabitacionGestion gestion = new TipoHabitacionGestion();
            TipoHabitacion respuesta = gestion.buscarPorDesc(descripcion);
            if (respuesta == null)
            {
                MessageBox.Show("La descripcion no existe");
                return;
            }

            txtDescripcionTipoHabitacion.Text = respuesta.Descripcion;
            txtPrecio.Text = respuesta.Precio.ToString(); ;
           

        }
    }
    }
    

