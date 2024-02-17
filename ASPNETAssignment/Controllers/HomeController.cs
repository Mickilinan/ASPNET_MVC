using Microsoft.AspNetCore.Mvc;

namespace ASPNETAssignment.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult SignIn()
    {
        return View();
    }

}

