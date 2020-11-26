using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IBugReportsService
    {
        Task CreateBugReportAsync(string accountId, string title, string description, string notes);

        Task ResolveBugReportAsync(string bugReportId);

        BugReport GetReportById(string bugReportId);

        T GetBugReportByIdGeneric<T>(string bugReportId);

        IEnumerable<T> GetAllByAccountUnresolved<T>(string accountId);

        IEnumerable<T> GetAllByAccountResolved<T>(string accountId);

        IEnumerable<T> GetAllAdminUnresolved<T>();

        IEnumerable<T> GetAllAdminResolved<T>();
    }
}
