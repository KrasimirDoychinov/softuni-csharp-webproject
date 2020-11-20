using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IServerService
    {
        Task CreateServerAsync(string name);

        IEnumerable<T> GetAll<T>();
    }
}
