using HolocronProject.Data.Models;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IBaseThreadService 
    {
        Task CreateBaseThread(string title);

        Task DeleteBaseThread(string baseThreadId);
    }
}
