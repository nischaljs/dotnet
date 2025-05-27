using Microsoft.AspNetCore.Mvc;
using webappDemo.Models;
using System.Collections.Generic;

namespace webappDemo.Controllers
{
    // Controller to handle all actions related to Students
    public class StudentController : Controller
    {
        // Action method that handles requests to /Student/Index
        public IActionResult Index()
        {
            // Create a dummy list of students to pass to the view
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Alice", Age = 22, Gender = "Female" },
                new Student { Id = 2, Name = "Bob", Age = 23, Gender = "Male" },
                new Student { Id = 3, Name = "Charlie", Age = 21, Gender = "Non-binary" }
            };

            // Pass the list to the view
            return View(students);
        }
    }
}
