using ASPNETAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETAssignment.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var homeViewModel = new HomeViewModel
        {
            SubscribeViewModel = new SubscribeViewModel
            {
                
            }
        };

        return View(homeViewModel);
    }

  

}

