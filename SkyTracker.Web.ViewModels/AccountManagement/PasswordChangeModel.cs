namespace SkyTracker.Web.ViewModels.AccountManagement;

using System.ComponentModel.DataAnnotations;
using static Common.DataModelsValidationConstants.Password;
using static Common.ErrorMessageStrings.PasswordChange;

public class PasswordChangeModel
{
    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Current password")]
    public string OldPassword { get; set; } = null!;

    [Required]
    [StringLength(PasswordLengthMax, ErrorMessage = PasswordErrorMessageLength, MinimumLength = PasswordLengthMin)]
    [DataType(DataType.Password)]
    [Display(Name = "New password")]
    public string NewPassword { get; set; } = null!;

    [DataType(DataType.Password)]
    [Display(Name = "Confirm new password")]
    [Compare("NewPassword", ErrorMessage = PasswordErrorMessageConfirmation)]
    public string ConfirmPassword { get; set; } = null!;
}