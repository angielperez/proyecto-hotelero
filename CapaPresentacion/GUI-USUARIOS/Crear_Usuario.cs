using CapaEntidades.ClasesHijas;
using CapaEntidades.ClasesPadres;
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

namespace CapaPresentacion
{
    public partial class Crear_Usuario : Form
    {
        public Crear_Usuario()
        {
            InitializeComponent();
        }

        private void Crear_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void btnGuardarReserva_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreUsuario.Text;
            string apellido = txtApellidoUsuario.Text;
            string telefono = txtTelUsuario.Text;
            string cedula = txtCedulaUsuario.Text;
            string correo = txtCorreoUsuario.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;



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
            if (username == "")
            {
                MessageBox.Show("El nombre de usuario es un campo obligatorio");
                return;
            }
            if (password == "")
            {
                MessageBox.Show("La contraseña es un campo obligatorio");
                return;
            }
           
      

            UsuarioGestion usuarioGestion = new UsuarioGestion();
            Usuario usuario = usuarioGestion.buscarPorUsername(username);

            if (usuario != null)
            {
                MessageBox.Show("Ya existe un usuario con ese nombre de usuario");
                return;
            }


            usuario = new Usuario();
            usuario.Nombre = nombre;
            usuario.Apellido = apellido;
            usuario.Cedula = cedula;
            usuario.Correo = correo;
            usuario.Telefono = telefono;
            usuario.username = username;
            usuario.password = password;
            usuario.IdHotel = 1;
            string mensaje = usuarioGestion.guardar(usuario);

            MessageBox.Show(mensaje);
        }

       
    }
}

