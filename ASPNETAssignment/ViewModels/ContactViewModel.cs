using ASPNETAssignment.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ASPNETAssignment.ViewModels;

public class ContactViewModel
{
	public ContactModel Contact { get; set; } = null!;
	public List<string> Services { get; set; } = null!;

	[BindNever]
	public string StatusMessage { get; set; } = null!;
	

}
