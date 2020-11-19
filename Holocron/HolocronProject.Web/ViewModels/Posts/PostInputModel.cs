using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Posts
{
    using static Data.Common.GlobalErrorMessages;
    using static Data.Common.GlobalRangeConstraints;
    public class PostInputModel 
    {
        [Required]
        [MaxLength(PostConstants.DescriptionMaxLength, ErrorMessage = PostErrorMessages.DescriptionMaxLengthError)]
        public string Description { get; set; }

        [Required]
        public string AccountId { get; set; }

        [Required]
        public string ThreadId { get; set; }

    }
}
