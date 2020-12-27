using System.Collections.Generic;

using AutoMapper;

namespace HolocronProject.Services
{
    public interface IRacesService
    {
        IEnumerable<T> GetAll<T>(IMapper mapper = null);
    }
}
