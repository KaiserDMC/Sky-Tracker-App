namespace SkyTracker.Web.ViewModels.AccountManagement;

using System.ComponentModel.DataAnnotations;
using static Common.ErrorMessageStrings.PersonalData;

public class DeletePersonalDataModel
{
    [Required(ErrorMessage = PersonalDataMessage)]
    [Display(Name = "Confirmation")]
    public string Confirmation { get; set; } = null!;
}