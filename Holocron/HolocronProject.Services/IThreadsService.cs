using System.Threading.Tasks;
using System.Collections.Generic;

using AutoMapper;

using HolocronProject.Services.Models.Threads;

namespace HolocronProject.Services
{
    public interface IThreadsService
    {
        Task DeleteAllThreadsByAccountId(string accountId);

        Task CreateThreadAsync(ThreadInputDto input);

        Task DeleteThreadAsync(string threadId);

        Task EditThreadAsync(string threadId, string description, string title);

        T GetThreadById<T>(string threadId, IMapper mapper = null);

        IEnumerable<T> GetLastNotDeletedThreadsByAccountId<T>(string accountId, IMapper mapper = null);

        IEnumerable<T> GetAllThreads<T>(IMapper mapper = null);

        int TotalThreads();

    }
}
