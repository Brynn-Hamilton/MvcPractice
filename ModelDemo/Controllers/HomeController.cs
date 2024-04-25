using Microsoft.AspNetCore.Mvc;
using ModelDemo.Models;
using System.Diagnostics;

namespace ModelDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Sample()
        {
            Person fred = new Person(){FirstName = "Fred", LastName = "Franklin", Email = "Frankief@abc.com", BirthYear = 1976 };

            return View(fred);
        }

        public IActionResult SampleList()
        {
            List<Person> people = new List<Person>();
            Person person = new Person("Fred", "Franklin", "Frankief@abc.com", 1976);
            people.Add(person);
            person = new Person("Sally", "Smith", "sally@abc.com", 1994);
            people.Add(person);
            person = new Person("Julia", "Jones", "jj18@abc.com", 2012);
            people.Add(person);

            ViewData["Department"] = "IT";
            ViewData["Year"] = 2023;

            return View(people);
        }

        public IActionResult ShowRegister()
        {
            return View();
        }

        public IActionResult Register(Person person)
        {
            ViewBag.BornMessage = "Hi";

            return View(person);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}