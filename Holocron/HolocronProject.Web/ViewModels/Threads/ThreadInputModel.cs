using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Posts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
