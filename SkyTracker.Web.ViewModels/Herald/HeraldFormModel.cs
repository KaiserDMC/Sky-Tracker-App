namespace SkyTracker.Web.ViewModels.Herald;

using System.ComponentModel.DataAnnotations;

using static Common.DataModelsValidationConstants.HeraldPost;
using static Common.ErrorMessageStrings.Herald;

public class HeraldFormModel
{
    public Guid Id { get; set; }

    [Required]
    [DisplayFormat(DataFormatString = DateString)]
    public DateTime Occurrence { get; set; }

    [Required]
    [Display(Name = "Type of occurrence")]
    public string TypeOccurrence { get; set; } = null!;

    [Required]
    [StringLength(DetailsLengthMax, MinimumLength = DetailsLengthMin, ErrorMessage = DetailsLength)]
    public string Details { get; set; } = null!;

    public string? Error { get; set; }

    public IEnumerable<HeraldTypeModel> HeraldTypes { get; set; } = new List<HeraldTypeModel>();
}