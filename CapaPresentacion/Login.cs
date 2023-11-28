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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;   
            string clave = txtClave.Text;
            if(usuario == "")
            {
                MessageBox.Show("El campo usuario es obligatorio");
                return;
            }

            if (clave == "")
            {
                MessageBox.Show("El campo contraseña es obligatorio");
                return;
            }

            UsuarioGestion gestion  = new UsuarioGestion();
            bool respueta = gestion.login(usuario, clave);
            if (respueta == true)
            {
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
            
        }
    }
}
