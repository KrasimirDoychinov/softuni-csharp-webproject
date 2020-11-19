using System.Collections.Generic;
using System.Threading.Tasks;
using HolocronProject.Data.Models;
using HolocronProject.Services.Models.Threads;

namespace HolocronProject.Services
{
    public interface IThreadService
    {
        Task CreateThreadAsync(ThreadInputDto input);

        T GetThreadById<T>(string threadId);

    }
}
