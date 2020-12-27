using System.Collections.Generic;

using AutoMapper;

namespace HolocronProject.Services
{
    public interface IBaseThreadsService 
    {
        IEnumerable<T> GetAll<T>(IMapper mapper = null);

        T GetById<T>(string id, IMapper mapper);
    }
}
