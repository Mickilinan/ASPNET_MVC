using ASPNETAssignment.Models;

namespace ASPNETAssignment.ViewModels;

public class ContactViewModel
{
	public ContactModel Contact { get; set; }
	public List<string> Services { get; set; }
	public string StatusMessage { get; set; }
	public string FullName { get; set; }	
	public string EmailAddress { get; set; }
	public string? Service { get; set; }
	public string Message { get; set; }
}
