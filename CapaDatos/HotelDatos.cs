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
    public class HotelDatos: ConexionBaseDatos
    {
        public bool guardar(Hotel hotel)
        {
            try
            {
                string sql = $"INSERT INTO HOTELES" +
                    $"(NOMBRE, DIRECCION, CORREO) " +
                    $"VALUES " +
                    $"('{hotel.Nombre}', '{hotel.Direccion}', '{hotel.Correo}', )";
                EjecutarComando(sql);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Hotel> leer()
        {
            string sql = $"SELECT * FROM HOTELES";
            return EjecutarComandoSelect<Hotel>(sql);
        }

        public bool actualizar(long id, Hotel hotel)
        {
            try
            {
                string sql = $"UPDATE HOTELES " +
                    $"SET NOMBRE = '{hotel.Nombre}', " +
                    $"DIRECCION = '{hotel.Direccion}', " +
                    $"CORREO = '{hotel.Correo}', " +
                    $"WHERE IDCLIENTE = {id}";
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
                string sql = $"DELETE FROM HOTELES " +
                    $"WHERE IDHOTEL = {id}";
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

