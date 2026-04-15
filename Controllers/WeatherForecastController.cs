using Microsoft.AspNetCore.Mvc;

namespace SecureWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("API is working");
        }

        [HttpGet("secret")]
        public IActionResult GetSecret()
        {
            var secret = Environment.GetEnvironmentVariable("MY_SECRET");

            if (string.IsNullOrEmpty(secret))
            {
                return Ok("No secret found");
            }

            return Ok($"Secret value is: {secret}");
        }
    }
}