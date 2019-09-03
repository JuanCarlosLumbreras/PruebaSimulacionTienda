using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaSimulacionTienda.Models
{
    public class RegistroItem
    {
        List<Items> listaItems;
        static RegistroItem ItemRegistro = null;

        private RegistroItem()
        {
            listaItems = new List<Items>();
        }
        public static RegistroItem getInstace()
        {
            if(ItemRegistro == null)
            {
                ItemRegistro = new RegistroItem();
                return ItemRegistro;
            }
            else
            {
                return ItemRegistro;
            }
        }

        public void Anadir(Items item)
        {
            listaItems.Add(item);
        }

        public String Borrar(String id)
        {
            String mensaje = "No se pudo Borrar";
            for(int i=0; i<listaItems.Count; i++)
            {
                Items it = listaItems.ElementAt(i);
                if (it.Id.Equals(id))
                {
                    listaItems.RemoveAt(i);
                    mensaje = "Borrado con exito";
                }
            }
            return mensaje;
        }
        public List<Items> VerItems()
        {
            return listaItems;
        }

        public List<Tuple<string,double>> VerNombresItems()
        {
            List<Tuple<string,double>> listaNombres = new List<Tuple<string, double>>();
            foreach(Items i in listaItems)
            {
                listaNombres.Add(new Tuple<String, double>(i.Nombre,i.Precio));
            }
            return listaNombres;
        }

        public String Actualizar(Items it)
        {
            String mensaje = "No se pudo Actualizar";
            for (int i = 0; i < listaItems.Count; i++)
            {
                Items it2 = listaItems.ElementAt(i);
                if (it2.Id.Equals(it.Id))
                {
                    listaItems[i] = it;
                    mensaje = "Actualizador con exito";
                }
            }
            return mensaje;
        }

    }
}
