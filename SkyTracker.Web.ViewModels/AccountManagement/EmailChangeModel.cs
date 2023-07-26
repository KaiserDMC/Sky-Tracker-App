namespace SkyTracker.Web.ViewModels.AccountManagement;

using System.ComponentModel.DataAnnotations;

public class EmailChangeModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "New email")]
    public string NewEmail { get; set; } = null!;
}