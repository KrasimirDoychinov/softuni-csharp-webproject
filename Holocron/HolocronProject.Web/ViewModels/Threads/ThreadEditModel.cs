using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.Threads
{
    public class ThreadEditModel : IMapFrom<Thread>
    {
        public string ThreadId { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.PostConstants.DescriptionMaxLength, ErrorMessage = GlobalErrorMessages.PostErrorMessages.DescriptionMaxLengthError)]
        public string Description { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.ThreadConstants.TitleMaxLength, ErrorMessage = GlobalErrorMessages.ThreadErrorMessages.TitleMaxLengthError)]
        public string Title { get; set; }
    }
}
