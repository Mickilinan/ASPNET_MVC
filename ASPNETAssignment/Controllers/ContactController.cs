using ASPNETAssignment.Models;
using ASPNETAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETAssignment.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			ViewData["Title"] = "Contact us";
			var viewModel = new ContactViewModel

			{
				Contact = new ContactModel()
			};

			return View(viewModel);

		}
	}
}
