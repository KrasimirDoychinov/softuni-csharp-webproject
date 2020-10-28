using HolocronProject.Data.Models;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IBaseThreadService 
    {
        Task CreateNewBaseThread(string title);

        Task DeleteBaseThread(string baseThreadId);
    }
}
