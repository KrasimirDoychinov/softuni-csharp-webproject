using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data.Models;
using AutoMapper;

namespace HolocronProject.Services
{
    public interface IRacesService
    {
        IEnumerable<T> GetAll<T>(IMapper mapper = null);
    }
}
