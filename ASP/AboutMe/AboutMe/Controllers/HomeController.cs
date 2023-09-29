using AboutMe.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AboutMe.Controllers
{
    public class HomeController : Controller
    {
        Person person = new Person();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string[] hobby = { "Чтение книг", "Походы в горы", "Катание на велосипеде", "Играть в настольные и компьютерные игры" };
            person.Hobby = hobby;
            return View(person);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Education()
        {
            person.Education = "Среднее специальное: Слесарь по ремонту автомобилей";
            return View(person);
        }
        public IActionResult Skills()
        {
            string[] skills = { "C++", "C#", "JavaScript", "HTML", "CSS", "React", "nodeJs", ".Net Core", ".Net Fremework", "SQL Server", "WPF", "WinForms", "Entity Framework", "GIT" };
            person.Skills = skills;
            return View(person);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}