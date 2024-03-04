using ASPNETAssignment.Models;

namespace ASPNETAssignment.ViewModels;

public class ContactViewModel
{
    public ContactModel Contact { get; set; } = null!;
    public List<string> Services { get; set; } = null!;
    public string StatusMessage { get; set; } = null!;


}