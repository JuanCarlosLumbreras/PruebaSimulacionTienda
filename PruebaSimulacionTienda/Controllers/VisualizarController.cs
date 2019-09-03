using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaSimulacionTienda.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaSimulacionTienda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisualizarController : Controller
    {

        [HttpGet]
        public List<Items> VerTodosItems()
        {
            return RegistroItem.getInstace().VerItems();
        }

        [HttpGet("VerNombres")]

        public List<Tuple<String,double>> VerNombresItems()
        {
            return RegistroItem.getInstace().VerNombresItems();
        }
        
    }
}
