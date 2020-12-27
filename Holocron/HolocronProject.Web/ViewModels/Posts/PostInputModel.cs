using System.ComponentModel.DataAnnotations;

namespace HolocronProject.Web.ViewModels.Posts
{
    using static Data.Common.GlobalErrorMessages;
    using static Data.Common.GlobalRangeConstraints;
    public class PostInputModel 
    {
        [Required]
        [MaxLength(PostConstants.DescriptionMaxLength, ErrorMessage = PostErrorMessages.DescriptionMaxLengthError)]
        public string Description { get; set; }

    }
}
