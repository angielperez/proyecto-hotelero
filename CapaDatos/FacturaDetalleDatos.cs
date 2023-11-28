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
    public class FacturaDetalleDatos : ConexionBaseDatos
    {
        public bool guardar(FacturaDetalle facturaDetalle)
        {
            try
            {
                string sql = $"INSERT INTO FACTURA_DETALLES" +
                    $"(IDFACTURA, IDPRODUCTO, CANTIDADPRODUCTO, PRECIOPRODUCTO, VALOR) " +
                    $"VALUES " +
                    $"({facturaDetalle.IdFactura}, {facturaDetalle.IdProducto}, {facturaDetalle.CantidadProducto}, {facturaDetalle.PrecioProducto}, {facturaDetalle.Valor})";
                EjecutarComando(sql);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<FacturaDetalle> leer()
        {
            string sql = $"SELECT * FROM FACTURA_DETALLES";
            return EjecutarComandoSelect<FacturaDetalle>(sql);
        }

        public bool actualizar(long id, FacturaDetalle facturaDetalle)
        {
            try
            {
                string sql = $"UPDATE FACTURA_DETALLES " +
                    $"SET IDFACTURA = '{facturaDetalle.IdFactura}', " +
                    $"IDPRODUCTO = '{facturaDetalle.IdProducto}', " +
                    $"CANTIDADPRODUCTO = '{facturaDetalle.CantidadProducto}', " +
                    $"PRECIOPRODUCTO = '{facturaDetalle.PrecioProducto}', " +
                    $"VALOR = '{facturaDetalle.Valor}', " +
                    $"WHERE IDFACTURADETALLE = {id}";
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
                string sql = $"DELETE FROM FACTURA_DETALLES " +
                    $"WHERE IDFACTURADETALLE = {id}";
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



   
