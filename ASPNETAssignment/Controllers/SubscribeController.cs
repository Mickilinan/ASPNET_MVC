using Microsoft.AspNetCore.Mvc;

namespace ASPNETAssignment.Controllers;

public class SubscribeController : Controller
{
    public IActionResult Subscribe()
    {
        return View();
    }

    public IActionResult UnSubscribe()
    {
        return View();
    }
}
