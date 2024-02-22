using System.ComponentModel.DataAnnotations;

namespace ASPNETAssignment.Models;

public class SubscribeModel
{
    [Display(Name = "Email", Prompt = "Enter your email address")]
    [Required(ErrorMessage = "Invalid email")]
    public string Email { get; set; } = null!;
}
