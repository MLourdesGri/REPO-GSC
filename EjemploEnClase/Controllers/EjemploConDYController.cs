using EjemploEnClase.ConDY;
using EjemploEnClase.SinDY;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploEnClase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploConDYController : ControllerBase
    {
        private IEmailServiceConDY _emailServiceConDY;

        public EjemploConDYController(IEmailServiceConDY emailServiceConDY)
        {
            _emailServiceConDY = emailServiceConDY;
        }

        [HttpGet]
        public bool EnviarMailDY([FromQuery] string email)
        {
            UsuarioServiceConDY usuarioServiceConDY = new UsuarioServiceConDY(_emailServiceConDY);
            return usuarioServiceConDY.EnviarNotificacionUsuarioDY(email);
        }
    }
}
