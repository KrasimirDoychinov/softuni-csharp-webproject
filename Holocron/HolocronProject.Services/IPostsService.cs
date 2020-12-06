using System.Collections.Generic;
using System.Threading.Tasks;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models.Posts;

namespace HolocronProject.Services
{
    public interface IPostsService
    {
        Task CreatePostAsync(string description, string threadId, string accountId);

        Task DeletePostAsync(string postId);

        IEnumerable<T> GetLastPostsByAccountId<T>(string accountId);

        IEnumerable<T> GetAllLastPosts<T>();

        T GetPostById<T>(string postId);

        Task EditPostById(string postId, string description);

        int TotalPosts();

        int TotalPostInThread(string threadId);
    }
}
