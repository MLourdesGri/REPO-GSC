using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExampleAPI.EjemploClaseAbstracta;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaseAbstractaController : ControllerBase
    {
        [HttpGet]
        public string GetAnimalComer()
        {
            Gato gato = new Gato("Michi");
            Perro perro = new Perro("Pepito");
            return gato.Comer() + " " + perro.Comer();
        }
    }
}
