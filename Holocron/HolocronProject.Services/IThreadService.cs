using System.Collections.Generic;
using System.Threading.Tasks;
using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IThreadService
    {
        Task CreateThreadAsync(string title, string baseThreadId, string accountId);
    }
}
