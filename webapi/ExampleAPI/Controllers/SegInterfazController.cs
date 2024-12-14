using ExampleAPI.EjemploInterfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExampleAPI.EjemploInterfaz;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SegInterfazController : ControllerBase
    {
        [HttpGet]
        public string GetAnimalComer()
        {
            Base baseClass = new Base();
            Perro perro = new Perro();
            return baseClass.Comer(perro);
        }
    }
}
