using ExternalAPIConfigurations.APIResponses;
using ExternalAPIConfigurations.EndPointConfigurations;
using ExternalAPIResponse.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace DevApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private IAPIResponse mResponse { get; set; }

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IOptions<APISettings> options, IAPIResponse response)
        {
            mResponse = response;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<EmployeeDetailsModel> Get()
        {
            Dictionary<String, String> parameters = new Dictionary<string, string>()
            {
                {"Name", "Sandip" },
                {"Age", "40" }

            };


            var result = await mResponse.GetAsyncResponseMessageWithParameters("Test",parameters);
            var response = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
            var desrializeObject = JsonConvert.DeserializeObject<EmployeeDetailsModel>(response);
            
            
            if(desrializeObject != null)
            {
                return desrializeObject;
            }

            return null;

        }
    }
}
