using HolocronProject.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IBaseThreadsService 
    {
        IEnumerable<T> GetAll<T>();

        T GetById<T>(string id);
    }
}
