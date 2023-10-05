using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeatherForecast.Models;
using WeatherForecast.Services;

namespace WeatherForecast.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherApiServices weatherApiServices;

        public HomeController(IWeatherApiServices weatherApiServices)
        {
            this.weatherApiServices = weatherApiServices;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Weather(string city)
        {
            WeatherApiResponse result = null;
            try
            {
                result = await weatherApiServices.SearchByCityAsync(city);

            }
            catch(Exception ex)
            {
                ViewBag.errorMessages = ex.Message;
            }

            ViewBag.searchWeatherByCity = city;
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}