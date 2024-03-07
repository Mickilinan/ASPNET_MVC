using ASPNETAssignment.Helpers;
using System.ComponentModel.DataAnnotations;

namespace ASPNETAssignment.Models;

public class DeleteAccountModel
{
    [Display(Name = "Delete Account", Order = 1)]
    [CheckboxRequired(ErrorMessage = "You must confirm to delete account.")]
    public bool DeleteAccount { get; set; } = false;

}
