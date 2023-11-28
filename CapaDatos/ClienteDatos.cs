using CapaEntidades;
using CapaEntidades.ClasesHijas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClienteDatos: ConexionBaseDatos
    {
        public bool guardar(Cliente cliente)
        {
            try
            {
                string sql = $"INSERT INTO CLIENTES" +
                    $"(CEDULA, NOMBRE, APELLIDO, CORREO, TELEFONO, PERFIL, IDHOTEL) " +
                    $"VALUES " +
                    $"('{cliente.Cedula}', '{cliente.Nombre}', '{cliente.Apellido}', '{cliente.Correo}', '{cliente.Telefono}', '{cliente.Perfil}', '{cliente.IdHotel}')";
                EjecutarComando(sql);
                return true;
            }
            catch (Exception e)
            {
                bd.Close();
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Cliente> leer()
        {
            string sql = $"SELECT * FROM CLIENTES";
            return EjecutarComandoSelect<Cliente>(sql);
        }

        public bool actualizar(decimal id, Cliente cliente)
        {
            try
            {
                string sql = $"UPDATE CLIENTES " +
                    $"SET CEDULA = '{cliente.Cedula}', " +
                    $"NOMBRE = '{cliente.Nombre}', " +
                    $"APELLIDO = '{cliente.Apellido}', " +
                    $"CORREO = '{cliente.Correo}', " +
                    $"TELEFONO = '{cliente.Telefono}', " +
                    $"PERFIL = '{cliente.Perfil}', " +
                    $"IDHOTEL = '{cliente.IdHotel}' " +
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

        public bool eliminar(decimal id)
        {
            try
            {
                string sql = $"DELETE FROM CLIENTES " +
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
    }
}
