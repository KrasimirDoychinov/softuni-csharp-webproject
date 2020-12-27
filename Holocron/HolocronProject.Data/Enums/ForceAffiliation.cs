using System.ComponentModel.DataAnnotations;

namespace HolocronProject.Data.Enums
{
    public enum ForceAffiliation
    {
        Unknown = 0,
        None = 1,
        [Display(Name = "Light side")]
        LightSide = 2,
        [Display(Name = "Dark side")]
        DarkSide = 3,
    }
}
