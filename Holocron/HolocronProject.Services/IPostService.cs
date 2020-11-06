using System.Collections.Generic;
using System.Threading.Tasks;
using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IPostService
    {
        Task CreatePostAsync(string description, string accountId, string threadId);
    }
}
