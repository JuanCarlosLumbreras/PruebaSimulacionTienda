using System;

namespace PruebaSimulacionTienda.Models
{
    public class Items
    {
        private String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private Double precio;

        public Double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private String estado;

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}