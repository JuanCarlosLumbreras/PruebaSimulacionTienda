using Microsoft.AspNetCore.Mvc;
using PruebaSimulacionTienda.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaSimulacionTienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnadirItemController : Controller
    {
        [HttpPost]
        public Items AnadirItems(Items item)
        {
            Items it = new Items();
            RegistroItem.getInstace().Anadir(item);
            it.Id = item.Id;
            it.Nombre = item.Nombre;
            it.Precio = item.Precio;
            it.Estado = item.Estado;
            return it;
        }
    }
}