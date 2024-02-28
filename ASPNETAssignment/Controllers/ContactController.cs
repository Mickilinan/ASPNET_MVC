using Microsoft.AspNetCore.Mvc;

namespace ASPNETAssignment.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			ViewData["Title"] = "Contact us";
			return View();
		}
	}
}
