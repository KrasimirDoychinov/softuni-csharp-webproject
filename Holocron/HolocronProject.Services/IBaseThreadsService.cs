using AutoMapper;
using HolocronProject.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IBaseThreadsService 
    {
        IEnumerable<T> GetAll<T>(IMapper mapper = null);

        T GetById<T>(string id, IMapper mapper);
    }
}
