namespace SkyTracker.Web.ViewModels.User;

using System.ComponentModel.DataAnnotations;

using static Common.DataModelsValidationConstants.Password;
using static Common.DataModelsValidationConstants.UserCheck;
using static Common.ErrorMessageStrings.UserCheck;

public class RegisterViewModel
{
    [Required]
    [StringLength(UsernameLengthMax, MinimumLength = UsernameLengthMin, ErrorMessage = UsernameLengthError )]
    [RegularExpression(UsernameRegexPattern, ErrorMessage = UsernameRegexError)]
    [Display(Name = "Username")]
    public string UserName { get; set; } = null!;

    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; } = null!;

    [Required]
    [StringLength(PasswordLengthMax, MinimumLength = PasswordLengthMin, ErrorMessage = PasswordLengthError)]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; } = null!;

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = PasswordConfirmationError)]
    public string ConfirmPassword { get; set; } = null!;
}