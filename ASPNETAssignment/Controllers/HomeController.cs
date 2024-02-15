using Microsoft.AspNetCore.Mvc;

namespace ASPNETAssignment.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
