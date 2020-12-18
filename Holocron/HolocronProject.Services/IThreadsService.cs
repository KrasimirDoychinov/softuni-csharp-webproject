using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models.Threads;

namespace HolocronProject.Services
{
    public interface IThreadsService
    {
        Task CreateThreadAsync(ThreadInputDto input);

        Task DeleteThreadAsync(string threadId);

        Task EditThreadAsync(string threadId, string description, string title);

        T GetThreadById<T>(string threadId, IMapper mapper = null);

        IEnumerable<T> GetLastNotDeletedThreadsByAccountId<T>(string accountId, IMapper mapper = null);

        IEnumerable<T> GetAllNotDeletedThreads<T>(IMapper mapper = null);

        int TotalNotDeletedThreads();

    }
}
