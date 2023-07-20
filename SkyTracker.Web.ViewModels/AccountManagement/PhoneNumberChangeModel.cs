namespace SkyTracker.Web.ViewModels.AccountManagement;

using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

public class PhoneNumberChangeModel
{
    public string? CurrentPhoneNumber { get; set; }

    [Required(ErrorMessage = "Please enter your new phone number.")]
    [DataType(DataType.PhoneNumber)]
    [Display(Name = "New Phone Number")]
    public string NewPhoneNumber { get; set; } = null!;
}