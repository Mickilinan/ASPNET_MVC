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
				Contact = new ContactModel(),

               
            };

			return View(viewModel);
			
		}

        [HttpPost]
        public IActionResult Index(ContactViewModel viewModel)
        {

			if (ModelState.IsValid)
			{
				try
				{
					// Här kan du lägga till logik för att spara meddelandet i din databas om det är relevant
					// Exempel: _messageRepository.Save(viewModel.Contact);
					viewModel.Contact = new ContactModel();
					viewModel.StatusMessage = "Success - Form submitted";
				}
				catch (Exception ex)
				{
					// Logga undantaget eller inkludera detaljer i StatusMessage
					viewModel.StatusMessage = $"Error - Form not submitted: {ex.Message}";
				}
			}
			else
			{
				foreach (var modelState in ModelState)
				{
					if (modelState.Value.Errors.Count > 0)
					{
						System.Diagnostics.Debug.WriteLine($"Field: {modelState.Key}");
						foreach (var error in modelState.Value.Errors)
						{
							System.Diagnostics.Debug.WriteLine($"Error: {error.ErrorMessage}");
						}
					}
				}
				viewModel.StatusMessage = "Error - Form not submitted";
			}

			return View("Index", viewModel);
		}
    }
}
