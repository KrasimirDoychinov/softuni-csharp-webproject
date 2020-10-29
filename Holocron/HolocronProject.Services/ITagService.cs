using HolocronProject.Data.Models;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface ITagService
    {
        Task CreateTag(string name);
    }
}
