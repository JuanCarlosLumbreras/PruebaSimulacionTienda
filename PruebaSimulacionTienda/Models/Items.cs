using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaSimulacionTienda.Models
{
    public class Items
    {
        String id;
        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        String nombre;
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        Double precio;
        public Double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        String estado;
        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
