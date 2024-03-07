using System.ComponentModel.DataAnnotations;

namespace ASPNETAssignment.Models;

public class DeleteAccountModel
{
    [Display(Name = "Delete Account", Order = 1)]


    public bool DeleteAccount { get; set; } = false;

}
