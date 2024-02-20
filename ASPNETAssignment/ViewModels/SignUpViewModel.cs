namespace ASPNETAssignment.ViewModels;

public class SignUpViewModel
{
    public string PageTitle { get; set; } = "Sign up";
    public SignUpViewModel Form { get; set; } /*= new SignUpViewModel();*/
    public bool TermsAndConditions { get; set; } = false; 
}
