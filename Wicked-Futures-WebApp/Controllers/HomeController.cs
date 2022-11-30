using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Wicked_Futures_WebApp.Data;
using Wicked_Futures_WebApp.Models;

namespace Wicked_Futures_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EducationContent()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult IndustryTab()
        {
            return View();
        }
        public IActionResult EducatorTab()
        {
            return View();
        }

        public IActionResult Student()
        {
            return View();
        }

        public IActionResult Teacher()
        {
            return View();
        }

        public IActionResult TeacherLogin()
        {
            return View();
        }
        public IActionResult LessonPlans()
        {
            return View();
        }
        public IActionResult TeacherAssessments()
        {
            return View();
        }
        public IActionResult TeacherAssessmentIndividual()
        {
            return View();
        }

        public IActionResult TeacherRegistration()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
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