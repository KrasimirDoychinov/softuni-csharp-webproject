using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HolocronProject.Data.Enums
{
    public enum ForceAffiliation
    {
        Unknown = 0,
        [Display(Name = "Light side")]
        LightSide = 1,
        [Display(Name = "Dark side")]
        DarkSide = 2,
        [Display(Name = "Gray jedi")]
        Gray = 3
    }
}
