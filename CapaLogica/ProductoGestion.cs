using CapaDatos;
using CapaEntidades;
using CapaEntidades.ClasesHijas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ProductoGestion
    {
        public List<Producto> lista;

        ProductoDatos datos = new ProductoDatos();

        public ProductoGestion()
        {
            this.lista = datos.leer();
        }

        public string guardar(Producto producto)
        {
            Producto busqueda = buscarPorCodigo(producto.Codigo);
            if(busqueda == null)
            {
                datos.guardar(producto);
                return "Producto almacenado exitosamente";
            }
            return "Este codigo de producto ya se encuentra registrado";
        }

        public Producto buscarPorCodigo(string Codigo)
        {
            this.lista = datos.leer();
            foreach (Producto producto in lista)
            {
                if (producto.Codigo.Equals(Codigo))
                {
                    return producto;
                }
            }
            return null;
        }

        public Producto buscarPorNombre(string nombre)
        {
            this.lista = datos.leer();
            foreach (Producto producto in lista)
            {
                if (producto.Nombre.Equals(nombre))
                {
                    return producto;
                }
            }
            return null;
        }

        public Producto buscar(decimal IdProducto)
        {
            this.lista = datos.leer();
            foreach (Producto producto in lista)
            {
                if (producto.IdProducto.Equals(IdProducto))
                {
                    return producto;
                }
            }
            return null;
        }

        public bool ValidarCodigoExiste(string codigo)
        {
            this.lista = datos.leer();
            foreach (Producto producto in lista)
            {
                if (producto.Codigo.Equals(codigo))
                {
                    return true;
                }
            }
            return false;
        }
        public string eliminar(long IdProducto)
        {
            Producto busqueda = buscar(IdProducto);
            if (busqueda == null)
            {
                return "No se encontro producto con esta identificacion";
            }
            datos.eliminar(IdProducto);
            return "Eliminada exitosamente";
        }

        public string actualizar(string codigo, Producto nuevoProducto)
        {
            Producto busqueda = buscarPorCodigo(codigo);
            if(busqueda == null)
            {
                return "No se encontro producto con esta identificacion";
            }
            datos.actualizar(busqueda.IdProducto, nuevoProducto);
            return "Producto actualizado exitosamente";
        }

    }
}

