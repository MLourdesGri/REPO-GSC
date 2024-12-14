using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExampleAPI.EjemploHerencia;

namespace ExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HerenciaController : ControllerBase
    {
        [HttpGet("Perro")]
        public string GetPerro()
        {
            Perro perro = new Perro();
            perro.Nombre = "Pepito";
            perro.Raza = "Pastor Aleman";
            perro.Tamanio = "Grande";
            return perro.Comer();
        }
        [HttpGet("Gato")]
        public string GetGato()
        {
            Gato gato = new Gato();
            gato.Nombre = "Michi";
            gato.Raza = "Siames";
            gato.Pelaje = "Corto";
            return gato.Comer();
        }
    }
}
