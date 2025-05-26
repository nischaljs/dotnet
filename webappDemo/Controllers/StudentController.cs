
using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Next()
        {
            return View();
        }
    }
}
