using CapaDatos;
using CapaEntidades.ClasesHijas;
using System.Collections.Generic;

namespace CapaLogica
{
    public class HabitacionGestion
    {
        public List<Habitacion> lista;

        HabitacionDatos datos = new HabitacionDatos();

        public HabitacionGestion(){ this.lista = datos.leer(); }

        public string guardar(Habitacion habitacion)
        {
            datos.guardar(habitacion);
            return "Habitacion almacenada exitosamente";
        }

        public Habitacion buscar(decimal IdHabitacion)
        {
            this.lista = datos.leer();
            foreach (Habitacion habitacion in lista)
            {
                if (habitacion.IdHabitacion.Equals(IdHabitacion))
                {
                    return habitacion;
                }
            }
            return null;
        }

        public Habitacion buscarPorNumHab(int NumeroHabitacion)
        {
            this.lista = datos.leer();
            foreach (Habitacion habitacion in lista)
            {
                if (habitacion.NumeroHabitacion.Equals(NumeroHabitacion))
                {
                    return habitacion;
                }
            }
            return null;
        }

        public string actualizar(decimal IdHabitacion, Habitacion nuevaHabitacion)
        {
            datos.actualizar(IdHabitacion, nuevaHabitacion);
            return "Habitación actualizada exitosamente";
        }

        public string eliminar(decimal IdHabitacion)
        {
            Habitacion busqueda = buscar(IdHabitacion);
            if (busqueda == null)
            {
                return "No se encontro habitacion con esta identificacion";
            }
            datos.eliminar(IdHabitacion);
            return "Eliminada exitosamente";
        }
    }

}

