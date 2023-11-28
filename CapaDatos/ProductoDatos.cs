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
    public class ProductoDatos: ConexionBaseDatos
    {
        public bool guardar(Producto producto )
        {
            try
            {
                string sql = $"INSERT INTO PRODUCTOS" +
                    $"(IDHOTEL, CODIGO, NOMBRE, DESCRIPCION, CANTIDAD, PRECIO) " +
                    $"VALUES " +
                    $"('{producto.IdHotel}', '{producto.Codigo}', '{producto.Nombre}', '{producto.Descripcion}', '{producto.Cantidad}', '{producto.Precio}')";
                EjecutarComando(sql);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Producto> leer()
        {
            string sql = $"SELECT * FROM PRODUCTOS";
            return EjecutarComandoSelect<Producto>(sql);
        }

        public bool actualizar(decimal id, Producto producto)
        {
            try
            {
                string sql = $"UPDATE PRODUCTOS " +
                    $"SET IDHOTEL = '{producto.IdHotel}', " +
                    $"CODIGO = '{producto.Codigo}', " +
                    $"NOMBRE = '{producto.Nombre}', " +
                    $"DESCRIPCION = '{producto.Descripcion}', " +
                    $"CANTIDAD = '{producto.Cantidad}', " +
                    $"PRECIO = '{producto.Precio}' " +
                    $"WHERE IDPRODUCTO = {id}";
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
                string sql = $"DELETE FROM PRODUCTOS " +
                    $"WHERE IDPRODUCTO = {id}";
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

