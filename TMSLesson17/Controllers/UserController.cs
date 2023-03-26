using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TMSLesson17.Models;

namespace TMSLesson17.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserViewModel model)
        {
            if (ModelState.IsValid && model.Username.Equals("admin") && model.Password.Equals("admin"))
            {
                return RedirectToAction("Inventory", "Storage");
            }
            else
            {
                return RedirectToAction("Create", "User");
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public string Create(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                return $"Username: {model.Username}";
            }
            else
            {
                return "Данные не прошли валидацию";
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}