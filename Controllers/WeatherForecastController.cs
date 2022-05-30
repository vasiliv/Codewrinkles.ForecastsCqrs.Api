using Microsoft.AspNetCore.Mvc;

namespace ForecastsCqrs.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {        

        public WeatherForecastController()
        {
            
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task <IActionResult>Get()
        {
            await Task.Delay(10);
            return Ok("Hello");
        }
    }
}