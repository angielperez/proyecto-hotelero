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
    public class FacturaDatos: ConexionBaseDatos
    {
        public bool guardar(Factura factura)
        {
            try
            {
                string sql = $"INSERT INTO FACTURAS" +
                    $"(NUMERORESERVA, ESTADO, IDCLIENTE, FECHAFACTURACION, TOTALCUENTA) " +
                    $"VALUES " +
                    $"({factura.NumeroReserva}, '{factura.Estado}', {factura.IdCliente}, '{factura.FechaFacturacion.ToString("dd/MM/yyyy")}', {factura.TotalCuenta})";
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

        public List<Factura> leer()
        {
            string sql = $"SELECT * FROM FACTURAS ORDER BY FECHAFACTURACION DESC";
            return EjecutarComandoSelect<Factura>(sql);
        }

        public bool anular(decimal idFactura)
        {
            try
            {
                string sql = $"UPDATE FACTURAS SET ESTADO = 'Anulada' WHERE IDFACTURA = {idFactura}";
                EjecutarComando(sql);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool finalizarFactura(decimal idFactura)
        {
            try
            {
                List<ParametroProcedimiento> parametros = new List<ParametroProcedimiento>();
                parametros.Add(new ParametroProcedimiento()
                {
                    Nombre = "id_factura", Valor = idFactura.ToString(),
                });
                EjecutarComandoProcedimiento("calcular_total_factura", parametros);
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

