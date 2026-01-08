using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/weather")]
    public class WeatherController : ControllerBase
    {
        // GET: api/weather
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new[] { "Sunny", "Cloudy", "Rainy" });
        }

        // GET: api/weather/today
        [HttpGet("today")]
        public IActionResult GetToday()
        {
            return Ok("Sunny");
        }

        // GET: api/weather/{city}
        [HttpGet("{city}")]
        public IActionResult GetByCity(string city)
        {
            return Ok($"Weather in {city} is Sunny");
        }
    }
}
