using System.ComponentModel.DataAnnotations;
using ASPNETAssignment.Helpers;

namespace ASPNETAssignment.Models;

public class DeleteAccountModel
{
    [Display(Name = "Delete Account", Order = 1)]

    [CheckboxRequired(ErrorMessage = "Your must agree to delete account to continue.")]
    public bool DeleteAccount { get; set; } = false;

}
