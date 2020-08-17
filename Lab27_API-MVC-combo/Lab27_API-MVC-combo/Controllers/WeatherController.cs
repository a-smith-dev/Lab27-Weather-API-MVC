using System.Collections.Generic;
using System.Threading.Tasks;
using Lab27_API_MVC_combo.Models;
using Lab27_API_MVC_combo.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab27_API_MVC_combo.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _weatherService.GetWeather("MapClick.php?lat=38.4247341&lon=-86.9624086&FcstType=json");
            model.CurrentObservation.Weatherimage = model.CurrentObservation.Weatherimage.Insert(0, @"http://forecast.weather.gov/newimages/medium/");
            model = FixIt(model);
            return View(model);
        }
        
        public Weather FixIt(Weather weather)
        {
            var direction = (int.Parse(weather.CurrentObservation.Windd) / 45) + 1;
            var directionTable = new Dictionary<int, string>{
                { 1 , "N" },
                { 2 , "NE" },
                { 3 , "E" },
                { 4 , "SE" },
                { 5 , "S" },
                { 6 , "SW" },
                { 7 , "W" },
                { 8 , "NW" }
            };
            directionTable.TryGetValue(direction, out string newDirection);
            weather.CurrentObservation.Windd = newDirection;

            return weather;
        }
    }
}
