using Microsoft.AspNetCore.Mvc;

namespace FoodOrder.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;


        public StockController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
    }
}
