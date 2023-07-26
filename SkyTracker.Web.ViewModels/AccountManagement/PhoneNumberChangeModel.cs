namespace SkyTracker.Web.ViewModels.AccountManagement;

using System.ComponentModel.DataAnnotations;
using static Common.ErrorMessageStrings.PhoneChange;

public class PhoneNumberChangeModel
{
    public string? CurrentPhoneNumber { get; set; }

    [Required(ErrorMessage = PhoneErrorMessage)]
    [DataType(DataType.PhoneNumber)]
    [Display(Name = "New Phone Number")]
    public string NewPhoneNumber { get; set; } = null!;
}