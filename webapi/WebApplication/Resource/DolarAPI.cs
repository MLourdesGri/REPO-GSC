using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebApplication.Model;

namespace WebApplication.Resource
{
    public class DolarAPI
    {
        public async Task<string> GetQuote()
        {
            string responseBody = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://dolarapi.com/v1/dolares/blue");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue
               ("application/json"));

                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                response.EnsureSuccessStatusCode();
                responseBody = response.Content.ReadAsStringAsync().Result;
            }
            return responseBody;

        }

        public async Task<string> GetSpecificQuote(Currency Currency)
        {
            string responseBody = string.Empty;
            using (var client = new HttpClient())
            {
                switch (Currency.CurrencyCode.ToUpper())
                {
                    case "BOLSA":
                        client.BaseAddress = new Uri("https://dolarapi.com/v1/dolares/bolsa\r\n");
                        break;
                    case "BLUE":
                        client.BaseAddress = new Uri("https://dolarapi.com/v1/dolares/blue\r\n");
                        break;
                    case "CRIPTO":
                        client.BaseAddress = new Uri("https://dolarapi.com/v1/dolares/cripto\r\n");
                        break;
                    default:
                        throw new ArgumentException("Currency type error");
                }
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));

                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                response.EnsureSuccessStatusCode();

                responseBody = response.Content.ReadAsStringAsync().Result;
            }
            return responseBody;

        }

    }
}
