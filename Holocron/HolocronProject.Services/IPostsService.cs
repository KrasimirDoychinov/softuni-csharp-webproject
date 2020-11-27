using System.Collections.Generic;
using System.Threading.Tasks;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models.Posts;

namespace HolocronProject.Services
{
    public interface IPostsService
    {
        Task CreatePostAsync(string description, string threadId, string accountId);

        IEnumerable<T> GetLast10PostsByAccountId<T>(string accountId);
    }
}
