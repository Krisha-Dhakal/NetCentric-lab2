using Microsoft.AspNetCore.Mvc;

using WebApp1ByKrisha.Models;

namespace WebApp1ByKrisha.Controllers
{
    public class StudentController: Controller
    {
        public IActionResult MyRazorPage()
        {
            return View();
        }
        public IActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateStudent(Student s) 
        {
            if (ModelState.IsValid)
            {
                return View("StudentDetail", s);
            }
            else
            {
                return View(s);
            }
        }
        public IActionResult StudentDetail(Student s)
        {
            return View(s);
        }
    }
}
