using ForecastsCqrs.Application.Commands;
using ForecastsCqrs.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ForecastsCqrs.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;
        public WeatherForecastController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task <IActionResult>GetAll()
        {
            //argument of send is a querry
            var result = await _mediator.Send(new GetAllForecastsQuery());
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] WeatherForecast forecast)
        {
            var command = new CreateForecastCommand()
            {
                NewForecast = forecast
            };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}