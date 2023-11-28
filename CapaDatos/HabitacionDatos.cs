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
    public class HabitacionDatos: ConexionBaseDatos
    {
        public bool guardar(Habitacion habitacion)
        {
            try
            {
                string sql = $"INSERT INTO HABITACIONES" +
                    $"(IDHOTEL, IDTIPOHABITACION, NUMEROHABITACION, DESCRIPCION, ESTADO) " +
                    $"VALUES " +
                    $"('{habitacion.IdHotel}', '{habitacion.IdTipoHabitacion}', '{habitacion.NumeroHabitacion}', '{habitacion.Descripcion}', '{habitacion.Estado}')";
                EjecutarComando(sql);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Habitacion> leer()
        {
            string sql = $"SELECT * FROM HABITACIONES";
            return EjecutarComandoSelect<Habitacion>(sql);
        }

        public bool actualizar(decimal id, Habitacion habitacion)
        {
            try
            {
                string sql = $"UPDATE HABITACIONES " +
                    $"SET IDHOTEL = '{habitacion.IdHotel}', " +
                    $"IDTIPOHABITACION = '{habitacion.IdTipoHabitacion}', " +
                    $"NUMEROHABITACION = '{habitacion.NumeroHabitacion}', " +
                    $"DESCRIPCION = '{habitacion.Descripcion}', " +
                    $"ESTADO = '{habitacion.Estado}' " +
                    $"WHERE IDHABITACION = {id}";
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
                string sql = $"DELETE FROM HABITACIONES " +
                    $"WHERE IDHABITACION = {id}";
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

