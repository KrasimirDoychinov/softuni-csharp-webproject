using System.Collections.Generic;

using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IThreadService
    {
        IEnumerable<Thread> GetThreadsByTitle(string title);

        IEnumerable<Thread> GetLatestThreads();
    }
}
