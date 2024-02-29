using ASPNETAssignment.Models;

namespace ASPNETAssignment.ViewModels
{
    public class AccountDetailsViewModel
    {
        public string Title { get; set; } = "Account Details";

        public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel()
        {
            ProfileImage = "~/Images/contactDetailsImages/profile_image.svg",
            FirstName = "Sarah",
            LastName = "Kriborg",
            Email = "sarah.kriborg@domain.com"
        };

        public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();
    }
}
