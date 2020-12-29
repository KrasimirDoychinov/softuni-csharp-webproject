using System.ComponentModel.DataAnnotations;

namespace HolocronProject.Data.Enums
{
    public enum ForceAffiliation
    {
        None = 0,
        Unknown = 1,
        [Display(Name = "Light side")]
        LightSide = 2,
        [Display(Name = "Dark side")]
        DarkSide = 3,
    }
}
