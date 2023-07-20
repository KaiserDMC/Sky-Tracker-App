namespace SkyTracker.Web.ViewModels.AccountManagement;

using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

public class DeletePersonalDataModel
{
    [Required(ErrorMessage = "Please type 'DELETE' to confirm.")]
    [Display(Name = "Confirmation")]
    public string Confirmation { get; set; }
}