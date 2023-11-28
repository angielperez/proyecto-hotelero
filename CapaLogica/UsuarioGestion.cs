using CapaDatos;
using CapaEntidades;
using System.Collections.Generic;

namespace CapaLogica
{
    public class UsuarioGestion
    {
        public List<Usuario> lista;

        UsuarioDatos datos = new UsuarioDatos();

        public UsuarioGestion()
        {
            this.lista = datos.leer();
        }

        public string guardar(Usuario usuario)
        {
            datos.guardar(usuario);
            return "Usuario almacenado exitosamente";
        }

        public Usuario buscar(long Cedula)
        {
            this.lista = datos.leer();
            foreach (Usuario usuario in lista)
            {
                if (usuario.Cedula.Equals(Cedula))
                {
                    return usuario;
                }
            }
            return null;
        }
        public Usuario buscarPorUsername(string username)
        {
            this.lista = datos.leer();
            foreach (Usuario usuario in lista)
            {
                if (usuario.username.Equals(username))
                {
                    return usuario;
                }
            }
            return null;
        }
        public string eliminar(long IdUsuario)
        {
            Usuario busqueda = buscar(IdUsuario);
            if (busqueda == null)
            {
                return "No se encontro usuario con esta identificacion";
            }
            datos.eliminar(IdUsuario);
            return "Eliminado exitosamente";
        }

        public string actualizar(decimal IdUsuario, Usuario nuevoUsuario)
        {
            datos.actualizar(IdUsuario, nuevoUsuario);
            return "Usuario actualizado exitosamente";
        }

        public bool login(string nomusuario, string clave)
        {
            this.lista = datos.leer();
            foreach (Usuario usuario in lista)
            {
                if (usuario.username.Equals(nomusuario) && usuario.password.Equals(clave) && usuario.Perfil == "usuario")
                {
                    return true;
                }
            }
            return false;
        }
    }
}

