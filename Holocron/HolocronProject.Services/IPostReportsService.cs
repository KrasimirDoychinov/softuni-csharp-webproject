using AutoMapper;
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

        Task DeletePostReportAsync(string postReportid);

        Task ResolvePostReportAsync(string postReportId);

        PostReport GetPostReportById(string postReportId);

        T GetPostReportByIdGeneric<T>(string postReportId, IMapper mapper = null);

        IEnumerable<T> GetAllByAccountUnresolved<T>(string accountId, IMapper mapper = null);

        IEnumerable<T> GetAllByAccountResolved<T>(string accountId, IMapper mapper = null);

        IEnumerable<T> GetAllAdminUnresolved<T>(IMapper mapper = null);

        IEnumerable<T> GetAllAdminResolved<T>(IMapper mapper = null);

        int TotalUnresolvedPostReports();
    }
}
