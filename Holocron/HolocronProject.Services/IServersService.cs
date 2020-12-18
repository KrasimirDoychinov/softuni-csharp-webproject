using System.Threading.Tasks;
using System.Collections.Generic;

using HolocronProject.Data.Models;
using AutoMapper;

namespace HolocronProject.Services
{
    public interface IServersService
    {
        IEnumerable<T> GetAll<T>(IMapper mapper = null);
    }
}
