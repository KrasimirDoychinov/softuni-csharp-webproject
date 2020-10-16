using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Services
{
    public interface IThreadService
    {
        IEnumerable<Thread> GetThreadsByTitle(string title);

        IEnumerable<Thread> GetLatestThreads();
    }
}
