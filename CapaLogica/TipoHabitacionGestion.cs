using CapaDatos;
using CapaEntidades;
using CapaEntidades.ClasesHijas;
using CapaEntidades.ClasesPadres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class TipoHabitacionGestion
    {
        public List<TipoHabitacion> lista;

        TipoHabitacionDatos datos = new TipoHabitacionDatos();

        public TipoHabitacionGestion()
        {
            this.lista = datos.leer();
        }

        public string guardar(TipoHabitacion tipoHabitacion)
        {
            datos.guardar(tipoHabitacion);
            return "Tipo de habitacion almacenado exitosamente";
        }

        public TipoHabitacion buscar(decimal IdTipoHabitacion)
        {
            this.lista = datos.leer();
            foreach (TipoHabitacion tipoHabitacion in lista)
            {
                if (tipoHabitacion.IdTipoHabitacion.Equals(IdTipoHabitacion))
                {
                    return tipoHabitacion;
                }
            }
            return null;
        }

        public TipoHabitacion buscarPorDesc(string descripcion)
        {
            this.lista = datos.leer();
            foreach (TipoHabitacion tipoHabitacion in lista)
            {
                if (tipoHabitacion.Descripcion.Equals(descripcion))
                {
                    return tipoHabitacion;
                }
            }
            return null;
        }
        public string actualizar(decimal IdTipoHabitacion, TipoHabitacion nuevoTipoHabitacion)
        {
            datos.actualizar(IdTipoHabitacion, nuevoTipoHabitacion);
            return "Tipo de Habitación actualizado exitosamente";
        }

        public string eliminar(long IdTipoHabitacion)
        {
            TipoHabitacion busqueda = buscar(IdTipoHabitacion);
            if (busqueda == null)
            {
                return "No se encontro tipo de habitacion con esta identificacion";
            }
            datos.eliminar(IdTipoHabitacion);
            return "Eliminada exitosamente";
        }
    }
}

