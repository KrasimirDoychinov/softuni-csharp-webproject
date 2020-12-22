using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models.Posts;

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

        IEnumerable<T> GetAllNotDeletedPosts<T>(IMapper mapper = null);

        int TotalNotDeletedPosts();

        int TotalNotDeletedPostInThread(string threadId);
    }
}
