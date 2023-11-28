using CapaDatos;
using CapaEntidades;
using CapaEntidades.ClasesHijas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class HotelGestion
    {
        public List<Hotel> lista;

        HotelDatos datos = new HotelDatos();

        public HotelGestion(){ this.lista = datos.leer(); }

        public string guardar(Hotel hotel)
        {
            datos.guardar(hotel);
            return "Hotel almacenada exitosamente";
        }

        public Hotel buscar(long IdHotel)
        {
            this.lista = datos.leer();
            foreach (Hotel hotel in lista)
            {
                if (hotel.IdHotel.Equals(IdHotel))
                {
                    return hotel;
                }
            }
            return null;
        }

        public string eliminar(long IdHotel)
        {
            Hotel busqueda = buscar(IdHotel);
            if (busqueda == null)
            {
                return "No se encontro Hotel con esta identificacion";
            }
            datos.eliminar(IdHotel);
            return "Eliminada exitosamente";
        }
    }
}

