using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.Posts
{
    public class PostCountViewModel : IMapFrom<Post>
    {
        public bool IsDeleted { get; set; }
    }
}
