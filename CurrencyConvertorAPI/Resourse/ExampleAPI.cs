using Nancy.Json;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;

namespace CurrencyConvertorAPI.Resourse
{
    public class ExampleAPI
    {
        public async Task<decimal> GetSpecificQuote()
        {
            HttpResponseMessage response;
            using (var client = new HttpClient())
            {
                RequestCurrency currency = new RequestCurrency();
                currency.Code = "Bolsa";
                var jsonObject = new JavaScriptSerializer().Serialize(currency);
                var content = new StringContent(jsonObject.ToString(), Encoding.UTF8, "application/json");
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync("https://localhost:5001/api/Quote", content);
                if (!response.IsSuccessStatusCode)
                {
                    var httpResponse = new HttpResponseMessage(response.StatusCode);

                    httpResponse.ReasonPhrase = " CONNECTION ERROR";
                    httpResponse.Content = new StringContent("");
                    throw new HttpResponseException(httpResponse);
                }

                string str = response.Content.ReadAsStringAsync().Result;
                QuoteCurrencyResponse? result = JsonConvert.DeserializeObject<QuoteCurrencyResponse?>(str);
                return result.Venta;
            }
        }
    }
}
