using ASPNETAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETAssignment.Controllers;

public class SecurityController : Controller
{
    //private readonly SecurityService _securityService;

    //public SecurityController(SecurityService securityService)
    //{
    //    _securityService = securityService;
    //}

    [Route("/security")]
    public IActionResult ChangePassword()
    {
        var viewModel = new SecurityViewModel();
        //viewModel.Password = _securityService.ChangePassword();

        return View(viewModel);
    }

    [HttpPost]
    public IActionResult Security(SecurityViewModel viewModel)
    {
        //_accountService.SaveBasicInfo(viewModel.BasicInfo);
        return RedirectToAction(nameof(Security), viewModel);
    }
    [HttpPost]
    public IActionResult SavedCourses(SavedCoursesViewModel viewModel)
    {
        return RedirectToAction(nameof(SavedCourses), viewModel);
    }

    [HttpPost]
    public IActionResult AddressInfo(AccountDetailsViewModel viewModel)
    {
        //_accountService.SaveAddressInfo(viewModel.AddressInfo);
        return RedirectToAction(nameof(Details), viewModel);
    }



}
