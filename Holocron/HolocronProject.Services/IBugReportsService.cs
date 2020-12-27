using System.Threading.Tasks;
using System.Collections.Generic;

using AutoMapper;

using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IBugReportsService
    {
        Task CreateBugReportAsync(string accountId, string title, string description, string notes);

        Task ResolveBugReportAsync(string bugReportId);

        BugReport GetBugReportById(string bugReportId);

        T GetBugReportByIdGeneric<T>(string bugReportId, IMapper mapper);

        IEnumerable<T> GetAllByAccountUnresolved<T>(string accountId, IMapper mapper);

        IEnumerable<T> GetAllByAccountResolved<T>(string accountId, IMapper mapper);

        IEnumerable<T> GetAllAdminUnresolved<T>(IMapper mapper);

        IEnumerable<T> GetAllAdminResolved<T>(IMapper mapper);

        int TotalUnresolvedBugReports();
    }
}
