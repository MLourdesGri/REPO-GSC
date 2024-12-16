using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP_final.Factories;
using TP_final.Singletons;

namespace TP_final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SHController : ControllerBase
    {
        [HttpPost("crear")]
        public IActionResult CrearSuperHeroe(string tipo, string nombre)
        {
            try
            {
                var superHeroe = SuperHeroeFactory.CrearSuperHeroe(tipo, nombre);
                return Ok(superHeroe);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("visitarEnfermeria")]
        public IActionResult VisitarEnfermeria(string tipo, int saludActual, int cantidadVisitas)
        {
            // Validar el tipo de superhéroe
            var tiposValidos = new[] { "mago", "guerrero", "arquero" }; 
            if (!tiposValidos.Contains(tipo.ToLower()))
            {
                return BadRequest(new { Mensaje = $"El tipo de superhéroe '{tipo}' no es válido." });
            }

            var enfermeria = Enfermeria.Instance;
            int saludFinal = saludActual;

            for (int i = 0; i < cantidadVisitas; i++)
            {
                if (enfermeria.Atender())
                {
                    saludFinal = Math.Min(saludFinal + 1, 5); // Salud máxima de 5
                }
                else
                {
                    return Ok(new
                    {
                        Tipo = tipo,
                        Salud = saludFinal,
                        Mensaje = "No quedan visitas disponibles en la enfermería."
                    });
                }
            }

            return Ok(new
            {
                Tipo = tipo,
                Salud = saludFinal,
                Mensaje = "Visita completada exitosamente."
            });
        }
    }
}
