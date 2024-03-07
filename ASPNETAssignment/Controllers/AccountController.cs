using ASPNETAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETAssignment.Controllers;

public class AccountController : Controller
{
    //private readonly AccountService _accountService;

    //public AccountController(AccountService accountService)
    //{
    //    _accountService = accountService;
    //}

    [HttpGet]
    [Route("/account")]
    public IActionResult Details()
    {
        var viewModel = new AccountDetailsViewModel();
        //viewModel.BasicInfo = _accountService.GetBasicInfo();
        //viewModel.AddressInfo = _accountService.GetAddressInfo();

        return View(viewModel); 
    }

    [Route("/security")]
    public IActionResult Security(SecurityViewModel viewModel)
    {
        //_securityService.ChangePassword(viewModel.Password);
        return View (viewModel);
    }


    [Route("/mycourses")]
    public IActionResult SavedCourses(SavedCoursesViewModel viewModel)
    {
        return View (viewModel);
    }



    [HttpPost]
    public IActionResult BasicInfo(AccountDetailsViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View("Details", viewModel);
        }
        //_accountService.SaveBasicInfo(viewModel.BasicInfo);
        return RedirectToAction(nameof(Details), viewModel);
    }


    [HttpPost]
    public IActionResult AddressInfo(AccountDetailsViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View("Details", viewModel);
        }
        //_accountService.SaveAddressInfo(viewModel.AddressInfo);
        return RedirectToAction(nameof(Details), viewModel);
    }

    [HttpPost]
    public IActionResult Password(SecurityViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View("Security", viewModel);
        }
        //_accountService.SavePassword(viewModel.AddressInfo);
        return RedirectToAction(nameof(Security), viewModel);
    }

    [HttpPost]
    public IActionResult DeleteAccount(SecurityViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View("Security", viewModel);
        }
        //_accountService.SavePassword(viewModel.AddressInfo);
        return RedirectToAction(nameof(Security), viewModel);
    }

}
