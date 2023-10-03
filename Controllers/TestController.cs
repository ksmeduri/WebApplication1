using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet(Name = "GetTest")]
        public IEnumerable<WeatherForecast> Get() 
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = 32,
                Summary = ""
            }).ToArray();
        }
    }
}
