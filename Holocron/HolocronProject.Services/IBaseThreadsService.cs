using HolocronProject.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IBaseThreadsService 
    {
        Task CreateBaseThreadAsync(string title);

        Task DeleteBaseThreadByIdAsync(string baseThreadId);

        IEnumerable<T> GetAll<T>();

        T GetById<T>(string id);
    }
}
