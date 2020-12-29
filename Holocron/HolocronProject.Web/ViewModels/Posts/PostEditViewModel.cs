using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.Posts
{
    public class PostEditViewModel : PostInputModel, IMapFrom<Post>
    {
        public string PostId { get; set; }

        public string ThreadId { get; set; }
    }
}
