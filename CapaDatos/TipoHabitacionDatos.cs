using CapaEntidades;
using CapaEntidades.ClasesHijas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class TipoHabitacionDatos : ConexionBaseDatos
    {
        public bool guardar( TipoHabitacion tipoHabitacion)
        {
            try
            {
                string sql = $"INSERT INTO TIPO_HABITACIONES" +
                    $"(IDHOTEL, DESCRIPCION, PRECIO) " +
                    $"VALUES " +
                    $"('{tipoHabitacion.IdHotel}', '{tipoHabitacion.Descripcion}', {tipoHabitacion.Precio})";
                EjecutarComando(sql);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<TipoHabitacion> leer()
        {
            string sql = $"SELECT * FROM TIPO_HABITACIONES";
            return EjecutarComandoSelect<TipoHabitacion>(sql);
        }

        public bool actualizar(decimal id, TipoHabitacion tipoHabitacion)
        {
            try
            {
                string sql = $"UPDATE TIPO_HABITACIONES " +
                    $"SET IDHOTEL = '{tipoHabitacion.IdHotel}', " +
                    $"DESCRIPCION = '{tipoHabitacion.Descripcion}', " +
                    $"PRECIO = '{tipoHabitacion.Precio}', " +
                    $"WHERE IDTIPOHABITACION = {id}";
                EjecutarComando(sql);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool eliminar(decimal id)
        {
            try
            {
                string sql = $"DELETE FROM TIPOHABITACIONES " +
                    $"WHERE IDTIPOHABITACION = {id}";
                EjecutarComando(sql);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
