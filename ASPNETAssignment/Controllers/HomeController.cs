using ASPNETAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETAssignment.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var subscribeViewModel = new SubscribeViewModel
        {
          
        };

        return View(subscribeViewModel);
    }



}

