using HolocronProject.Data;
using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services.Implementations
{
    public class BugReportServices : IBugReportService
    {
        private readonly HolocronDbContext context;

        public BugReportServices(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task CreateBugReportAsync(string accountId, string title, string description)
        {
            var bugReport = new BugReport
            {
                AccountId = accountId,
                Title = title,
                Description = description
            };

            await this.context.BugReports.AddAsync(bugReport);
            await this.context.SaveChangesAsync();
        }

        public async Task ResolveBugReportAsync(string bugReportId)
        {
            var bugReport = GetBugReportById(bugReportId);

            bugReport.IsResolved = true;

            this.context.BugReports.Update(bugReport);
            await this.context.SaveChangesAsync();
        }

        public BugReport GetBugReportById(string bugReportId)
            => this.context.BugReports
            .FirstOrDefault(x => x.Id == bugReportId);
        
    }
}
