using AutoMapper;
using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services.Implementations
{
    public class BugReportsService : IBugReportsService
    {
        private readonly ApplicationDbContext context;

        public BugReportsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task CreateBugReportAsync(string accountId, string title, string description, string notes)
        {
            var bugReport = new BugReport
            {
                AccountId = accountId,
                Title = title,
                Description = description,
                Notes = notes
            };

            await this.context.BugReports.AddAsync(bugReport);
            await this.context.SaveChangesAsync();
        }

        public async Task ResolveBugReportAsync(string bugReportId)
        {
            var bugReport = GetBugReportById(bugReportId);

            bugReport.IsResolved = true;
            bugReport.ResolvedOn = DateTime.UtcNow;

            this.context.BugReports.Update(bugReport);
            await this.context.SaveChangesAsync();
        }

        public T GetBugReportByIdGeneric<T>(string bugReportId, IMapper mapper = null)
            => this.context.BugReports
            .Where(x => x.Id == bugReportId)
            .To<T>(mapper)
            .FirstOrDefault();

        public IEnumerable<T> GetAllByAccountUnresolved<T>(string accountId, IMapper mapper = null)
            => this.context.BugReports
            .Where(x => x.AccountId == accountId && !x.IsResolved)
            .OrderByDescending(x => x.CreatedOn)
            .To<T>(mapper)
            .ToList();

        public IEnumerable<T> GetAllByAccountResolved<T>(string accountId, IMapper mapper = null)
            => this.context.BugReports
            .Where(x => x.AccountId == accountId && x.IsResolved)
            .OrderByDescending(x => x.ResolvedOn)
            .To<T>(mapper)
            .ToList();

        public IEnumerable<T> GetAllAdminUnresolved<T>(IMapper mapper = null)
            => this.context.BugReports
            .Where(x => !x.IsResolved)
            .OrderByDescending(x => x.CreatedOn)
            .To<T>(mapper)
            .ToList();

        public IEnumerable<T> GetAllAdminResolved<T>(IMapper mapper = null)
            => this.context.BugReports
            .Where(x => x.IsResolved)
            .OrderByDescending(x => x.ResolvedOn)
            .To<T>(mapper)
            .ToList();

        public BugReport GetBugReportById(string bugReportId)
            => this.context.BugReports
            .FirstOrDefault(x => x.Id == bugReportId);

        public int TotalUnresolvedBugReports()
            => this.context.BugReports
            .Where(x => !x.IsResolved)
            .OrderByDescending(x => x.CreatedOn)
            .Count();
    }
}
