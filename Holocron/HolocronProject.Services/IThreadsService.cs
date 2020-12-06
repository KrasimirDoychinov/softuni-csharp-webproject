using System.Collections.Generic;
using System.Threading.Tasks;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models.Threads;

namespace HolocronProject.Services
{
    public interface IThreadsService
    {
        Task CreateThreadAsync(ThreadInputDto input);

        Task DeleteThreadAsync(string threadId);

        Task EditThreadAsync(string threadId, string description, string title);

        T GetThreadsById<T>(string threadId);

        IEnumerable<T> GetLastThreadsByAccountId<T>(string accountId);

        IEnumerable<T> GetAllLastThreads<T>();

        int TotalThreads();

    }
}
