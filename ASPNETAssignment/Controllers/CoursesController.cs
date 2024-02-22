using Microsoft.AspNetCore.Mvc;

namespace ASPNETAssignment.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult CoursesIndex()
        {
            return View();
        }
    }
}
