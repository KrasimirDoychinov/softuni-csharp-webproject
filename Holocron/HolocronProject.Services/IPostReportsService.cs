using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IPostReportsService
    {
        Task CreatePostReportAsync(string accountId, string postId, string title, string description, string notes);

        Task DeletePostReportAsync(string postReportid, string postId);

        Task ResolvePostReportAsync(string postReportId);

        PostReport GetReportById(string postReportId);

        T GetPostReportByIdGeneric<T>(string postReportId);

        IEnumerable<T> GetAllByAccountUnresolved<T>(string accountId);

        IEnumerable<T> GetAllByAccountResolved<T>(string accountId);

        IEnumerable<T> GetAllAdminUnresolved<T>();

        IEnumerable<T> GetAllAdminResolved<T>();

        int TotalUnresolvedPostReports();
    }
}
