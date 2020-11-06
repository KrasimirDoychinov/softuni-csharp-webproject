using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IBugReportService
    {
        Task CreateBugReportAsync(string accountId, string title, string description);

        Task ResolveBugReportAsync(string bugReportId);

        BugReport GetBugReportById(string bugReportId);
    }
}
