using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Bff.Controllers;

[ApiController]
[Route("bff/[controller]")]
public class BffWeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<BffWeatherForecastController> _logger;

    public BffWeatherForecastController(ILogger<BffWeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "BffGetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
