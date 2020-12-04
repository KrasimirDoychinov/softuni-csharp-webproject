using HolocronProject.Data.Common;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using System.ComponentModel.DataAnnotations;

namespace HolocronProject.Web.ViewModels.Posts
{
    public class PostEditViewModel : IMapFrom<Post>
    {
        public string PostId { get; set; }

        public string ThreadId { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.PostConstants.DescriptionMaxLength, ErrorMessage = GlobalErrorMessages.PostErrorMessages.DescriptionMaxLengthError)]
        public string Description { get; set; }
    }
}
