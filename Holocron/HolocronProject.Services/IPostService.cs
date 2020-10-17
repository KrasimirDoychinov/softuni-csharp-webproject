using System.Collections.Generic;

using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IPostService
    {
        IEnumerable<Post> GetPostByDescription(string description);
    }
}
