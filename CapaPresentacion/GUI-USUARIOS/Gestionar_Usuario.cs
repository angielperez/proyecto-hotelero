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

namespace CapaPresentacion.GUI_USUARIOS
{
    public partial class Gestionar_Usuario : Form
    {
        public Gestionar_Usuario()
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (username == "")
            {
                MessageBox.Show("Porfavor digite un nombre de usuario valido");
                return;
            }


            UsuarioGestion gestion = new UsuarioGestion();
            Usuario respuesta = gestion.buscarPorUsername(username);
            if (respuesta == null)
            {
                MessageBox.Show("El nombre de usuario no existe");
                return;
            }

            txtUsername.Text = respuesta.username;
            txtNombreUsuario.Text = respuesta.Nombre;
            txtApellidoUsuario.Text = respuesta.Apellido;
            txtCedulaUsuario.Text = respuesta.Cedula;
            txtCorreoUsuario.Text = respuesta.Correo;
            txtTelUsuario.Text = respuesta.Telefono;
            txtPassword.Text = respuesta.password;

        }

        private void txtCedulaUsuario_TextChanged(object sender, EventArgs e)
        {

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

            if (usuario == null)
            {
                MessageBox.Show("El nombre de usuario no existe");
                return;
            }


            usuario.Nombre = nombre;
            usuario.Apellido = apellido;
            usuario.Cedula = cedula;
            usuario.Correo = correo;
            usuario.Telefono = telefono;
            usuario.username = username;
            usuario.password = password;

            string mensaje = usuarioGestion.actualizar(usuario.IdUsuario, usuario);

            MessageBox.Show(mensaje);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
