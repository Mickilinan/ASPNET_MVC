using ASPNETAssignment.Models;

namespace ASPNETAssignment.ViewModels
{
    public class SecurityViewModel
    {
        public string Title { get; set; } = "Security";

        public ChangePasswordModel Password { get; set; } = new ChangePasswordModel()
        {
            ProfileImage = "images/contactDetailsImages/profile_image.svg",
            FirstName = "Sarah",
            LastName = "Kriborg",
            Email = "sarah.kriborg@domain.com"
        };

        public bool DeleteAccount { get; set; } = false;
    }

}
