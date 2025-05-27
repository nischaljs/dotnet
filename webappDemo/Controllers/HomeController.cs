using Microsoft.AspNetCore.Mvc; // Required for creating controllers and returning views

namespace TestWebApp.Controllers
{
    // HomeController is a class that handles requests to the home section of the website.
    // It inherits from the built-in Controller class which provides useful methods like View().
    public class HomeController : Controller
    {
        // This action method handles the request to the home page (e.g., https://yoursite.com/Home/Index  or https://yoursite.com/ )
        // IActionResult is a type that represents the result of an action method, such as a view, redirect, etc.
        // This method is called when the user navigates to the home page and IActionResult is the return type of the method.
        //  IActionResult is a type that represents the result of an action method, such as a view, redirect, etc.
        public IActionResult Index()
        {
            // Returns the "Index" view to the browser
            // The View() method looks for a file named "Index.cshtml" in the Views/Home folder by default
            return View();
        }

        // This action method handles the request to the next page (e.g., https://yoursite.com/Home/Next )
        public IActionResult Next()
        {
            // Returns the "Next" view to the browser
            // The View() method looks for a file named "Next.cshtml" in the Views/Home folder
            return View();
        }
    }
}
