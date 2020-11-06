using HolocronProject.Data.Models;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IBaseThreadService 
    {
        Task CreateBaseThreadAsync(string title);

        Task DeleteBaseThreadByIdAsync(string baseThreadId);
    }
}
