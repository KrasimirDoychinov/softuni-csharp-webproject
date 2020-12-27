using System.Collections.Generic;

using AutoMapper;

namespace HolocronProject.Services
{
    public interface IServersService
    {
        IEnumerable<T> GetAll<T>(IMapper mapper = null);
    }
}
