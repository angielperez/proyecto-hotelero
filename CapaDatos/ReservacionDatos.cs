using CapaEntidades;
using CapaEntidades.ClasesHijas;
using CapaEntidades.ClasesPadres;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ReservacionDatos : ConexionBaseDatos
    {
        public bool guardar(Reservacion reservacion)
        {
            try
            {
                string sql = $"INSERT INTO RESERVACIONES" +
                    $"(IDCLIENTE, IDHABITACION, NUMEROADULTOS, NUMERONIÑOS, FECHAINICIO, FECHAFIN, ESTADO) " +
                    $"VALUES " +
                    $"('{reservacion.IdCliente}', '{reservacion.IdHabitacion}', '{reservacion.NumeroAdultos}', '{reservacion.NumeroNiños}', '{reservacion.FechaInicio.ToString("dd/MM/yyyy")}', '{reservacion.FechaFin.ToString("dd/MM/yyyy")}', '{reservacion.Estado}')";
                EjecutarComando(sql);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Reservacion> leer()
        {
            string sql = $"SELECT * FROM RESERVACIONES ORDER BY NUMERORESERVA DESC";
            return EjecutarComandoSelect<Reservacion>(sql);
        }

        public bool actualizar(long id, Reservacion reservacion)
        {
            try
            {
                string sql = $"UPDATE RESERVACIONES " +
                    $"SET IDCLIENTE = '{reservacion.IdCliente}', " +
                    $"IDHABITACION = '{reservacion.IdHabitacion}', " +
                    $"NUMEROADULTOS = '{reservacion.NumeroAdultos}', " +
                    $"NUMERONIÑOS = '{reservacion.NumeroNiños}', " +
                    $"FECHAINICIO = '{reservacion.FechaInicio.ToString("dd/MM/yyyy")}', " +
                    $"FECHAFIN = '{reservacion.FechaFin.ToString("dd/MM/yyyy")}', " +
                    $"ESTADO = '{reservacion.Estado}' " +
                    $"WHERE NUMERORESERVA = {id}";
                EjecutarComando(sql);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool eliminar(long id)
        {
            try
            {
                string sql = $"DELETE FROM RESERVACIONES " +
                    $"WHERE NUMERORESERVACION = {id}";
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
