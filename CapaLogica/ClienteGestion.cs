using CapaDatos;
using CapaEntidades;
using System.Collections.Generic;

namespace CapaLogica
{
    public class ClienteGestion
    {

        public List<Cliente> lista;

        ClienteDatos datos = new ClienteDatos();

        public ClienteGestion(){
            this.lista = datos.leer();
        }

        public decimal guardar(Cliente cliente)
        {
            Cliente p = buscarPorCedula(cliente.Cedula);
            if (p == null)
            {
                datos.guardar(cliente);
                p = buscarPorCedula(cliente.Cedula);
                return p.IdCliente;
            }
            else
            {
                datos.actualizar(p.IdCliente, cliente);
                return p.IdCliente;
            }
        }

        public Cliente buscar(decimal idCliente)
        {
            this.lista = datos.leer();
            foreach (Cliente cliente in lista)
            {
                if (cliente.IdCliente.Equals(idCliente))
                {
                    return cliente;
                }
            }
            return null;
        }

        public Cliente buscarPorCedula(string Cedula)
        {
            this.lista = datos.leer();
            foreach (Cliente cliente in lista)
            {
                if (cliente.Cedula.Equals(Cedula))
                {
                    return cliente;
                }
            }
            return null;
        }

        public string eliminar(string Cedula)
        {
            Cliente p = buscarPorCedula(Cedula);
            if (p == null)
            {
                return "No se encontro el cliente con esta identificacion";
            }
            datos.eliminar(p.IdCliente);
            return "Eliminado exitosamente";            
        }
    }

}

