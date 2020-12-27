using System.Threading.Tasks;
using System.Collections.Generic;

using AutoMapper;

namespace HolocronProject.Services
{
    public interface IPostsService
    {
        Task DeleteAllPostsByAccountIdAsync(string accountId);

        Task CreatePostAsync(string description, string threadId, string accountId);

        Task DeletePostAsync(string postId);

        Task EditPostByIdAsync(string postId, string description);

        T GetNotDeletedPostById<T>(string postId, IMapper mapper = null);

        IEnumerable<T> GetLastNotDeletedPostsByAccountId<T>(string accountId, IMapper mapper = null);

        IEnumerable<T> GetAllPosts<T>(IMapper mapper = null);

        int TotalPosts();

        int TotalNotDeletedPostInThread(string threadId);
    }
}
