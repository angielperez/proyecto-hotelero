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
    public class UsuarioDatos : ConexionBaseDatos
    {
        public bool guardar(Usuario usuario)
        {
            try
            {
                string sql = $"INSERT INTO USUARIOS" +
                    $"(NOMBRE, APELLIDO,CEDULA, CORREO, TELEFONO, PERFIL, IDHOTEL, USERNAME, PASSWORD) " +
                    $"VALUES " +
                    $"('{usuario.Nombre}', '{usuario.Apellido}', '{usuario.Cedula}','{usuario.Correo}', '{usuario.Telefono}', '{usuario.Perfil}', '{usuario.IdHotel}', '{usuario.username}', '{usuario.password}')";
                EjecutarComando(sql);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Usuario> leer()
        {
            string sql = $"SELECT * FROM USUARIOS";
            return EjecutarComandoSelect<Usuario>(sql);
        }

        public bool actualizar(decimal id, Usuario usuario)
        {
            try
            {
                string sql = $"UPDATE USUARIOS " +
                    $"SET NOMBRE = '{usuario.Nombre}', " +
                    $"APELLIDO = '{usuario.Apellido}', " +
                    $"CEDULA = '{usuario.Cedula}', " +
                    $"CORREO = '{usuario.Correo}', " +
                    $"TELEFONO = '{usuario.Telefono}', " +
                    $"PERFIL = '{usuario.Perfil}', " +
                    $"IDHOTEL = '{usuario.IdHotel}', " +
                    $"USERNAME = '{usuario.username}' ," +
                    $"PASSWORD = '{usuario.password}' " +
                    $"WHERE IDUSUARIO = {id}";
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
                string sql = $"DELETE FROM USUARIOS " +
                    $"WHERE IDUSUARIO = {id}";
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
