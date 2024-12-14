using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExampleAPI.EjemploInterfaz;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterfazController : ControllerBase
    {
        [HttpGet(Name = "GetAnimal")]
        public string GetAnimalComer()
        {
            IAnimal animal = new Perro();
            return animal.Comer();
        }
    }
}
