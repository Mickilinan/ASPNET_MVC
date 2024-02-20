using ASPNETAssignment.Models;

namespace ASPNETAssignment.ViewModels;

public class SignUpViewModel
{
    public string PageTitle { get; set; } = "Sign up";

    //public SignUpViewModel Form { get; set; } = new SignUpViewModel();
    public SignUpModel Form { get; set; } = new SignUpModel();

    public bool TermsAndConditions { get; set; } = false; 

    public SignUpViewModel()
    {

    }
}
