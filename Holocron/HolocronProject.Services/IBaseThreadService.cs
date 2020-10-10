using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IBaseThreadService 
    {
        // Admin services
        Task CreateAllCurrentBaseThreads();

        Task CreateNewBaseThread(string title);
    }
}
