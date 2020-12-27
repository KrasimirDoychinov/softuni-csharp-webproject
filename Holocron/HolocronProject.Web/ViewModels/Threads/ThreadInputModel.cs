using System.ComponentModel.DataAnnotations;

namespace HolocronProject.Web.ViewModels.Threads
{
    using static Data.Common.GlobalErrorMessages;
    using static Data.Common.GlobalRangeConstraints;

    public class ThreadInputModel 
    {
        [Required]
        [MaxLength(ThreadConstants.TitleMaxLength, ErrorMessage = ThreadErrorMessages.TitleMaxLengthError)]
        public string Title { get; set; }

        [Required]
        [MaxLength(ThreadConstants.DescriptionMaxLength, ErrorMessage = ThreadErrorMessages.DescriptionMaxLengthError)]
        public string Description { get; set; }

    }
}
