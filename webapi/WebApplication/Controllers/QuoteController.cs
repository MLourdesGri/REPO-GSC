using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication.Model;
using WebApplication.Resource;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        [HttpGet(Name ="GetQuote")]

        public string GetQuote()
        {
            DolarAPI api = new DolarAPI();
            return api.GetQuote().Result;
        }

        [HttpPost(Name = "GetSpecificQuote")]

        public async Task<string> GetSpecificQuote([FromBody] Currency Currency)
        {
            DolarAPI api = new DolarAPI();
            return await api.GetSpecificQuote(Currency);
        }
    }
}
