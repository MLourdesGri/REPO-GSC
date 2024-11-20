using CurrencyConvertorAPI.Resourse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CurrencyConvertorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConverterController : ControllerBase
    {
        [HttpGet(Name = "GetQuote")]

        public async Task<string> GetQuote([FromQuery, Required] decimal value)
        {
            ExampleAPI api = new ExampleAPI();
            decimal result = await api.GetSpecificQuote();
            return (result*value).ToString();
        }
    }
}
