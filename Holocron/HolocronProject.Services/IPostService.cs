using System.Collections.Generic;
using System.Threading.Tasks;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models.Posts;

namespace HolocronProject.Services
{
    public interface IPostService
    {
        Task CreatePostAsync(PostInputDto input);
    }
}
