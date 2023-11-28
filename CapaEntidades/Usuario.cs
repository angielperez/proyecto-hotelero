using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario: Persona
    {
        public decimal IdUsuario { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Usuario() {
            this.Perfil = "usuario";
        }
    }
}
