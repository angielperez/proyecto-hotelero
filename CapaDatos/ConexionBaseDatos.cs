using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConexionBaseDatos
    {
        public OracleConnection bd { get; set; } 

       
        public ConexionBaseDatos()
        {
            string cadenaConexion = "USER ID=proyecto;PASSWORD=proyecto;PERSIST SECURITY INFO=True;DATA SOURCE=localhost:1521/xe;";
            try
            {
                bd = new OracleConnection(cadenaConexion);
                Console.WriteLine("Conecto exitosamente");
            }
            catch (Exception e)
            {
                Console.WriteLine("NO Conecto");
                Console.WriteLine(e.Message);
            }            
        }

        //FUNCION PARA CONVERTIR UN DATAREADER DE LA BASE DE DATOS  EN UNA LISTA DE CUALQUIER OBJETO 
        public static List<T> DataReaderMapToList<T>(IDataReader dr)
        {
            List<T> list = new List<T>();
            T obj = default(T);
            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(dr[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, dr[prop.Name], null);
                    }
                }
                list.Add(obj);
            }
            return list;
        }

        public void EjecutarComando(string sql)
        {
            bd.Open();
            var sentencia = bd.CreateCommand();
            sentencia.CommandText = sql;
            sentencia.CommandType = CommandType.Text;
            sentencia.ExecuteNonQuery();
            bd.Close();
        }

        public void EjecutarComandoProcedimiento(string procedure, List<ParametroProcedimiento> parametros)
        {
            bd.Open();
            var sentencia = bd.CreateCommand();
            sentencia.CommandText = procedure;
            sentencia.CommandType = CommandType.StoredProcedure;
            foreach (var parametro in parametros)
            {
                sentencia.Parameters.Add(parametro.Nombre, parametro.Tipo).Value = parametro.Valor;
            }
            sentencia.ExecuteNonQuery();
            bd.Close();
        }

        public List<T> EjecutarComandoSelect<T>(string sql)
        {
            bd.Open();
            var sentencia = bd.CreateCommand();
            sentencia.CommandText = sql;
            sentencia.CommandType = CommandType.Text;
            OracleDataReader dr = sentencia.ExecuteReader();
            List<T> lista = DataReaderMapToList<T>(dr);
            bd.Close();
            return lista;
        }
    }

    public class ParametroProcedimiento
    {
        public string Nombre { get; set; }
        public string Valor { get; set; }
        public OracleType Tipo { get; set; } = OracleType.Number;
    }
}


