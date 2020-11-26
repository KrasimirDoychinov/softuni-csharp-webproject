using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IServersService
    {
        Task CreateServerAsync(string name);

        IEnumerable<T> GetAll<T>();
    }
}
