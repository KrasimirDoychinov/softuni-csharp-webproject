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
    public class PostReportsService : IPostReportsService
    {
        private readonly HolocronDbContext context;

        public PostReportsService(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task CreatePostReportAsync(string accountId, string postId, string title, string description, string notes)
        {
            var postReport = new PostReport
            {
                AccountId = accountId,
                PostId = postId,
                Title = title,
                Description = description,
                Notes = notes
            };

            await this.context.PostReports.AddAsync(postReport);
            await this.context.SaveChangesAsync();
        }

        public async Task ResolvePostReportAsync(string postReportId)
        {
            var postReport = this.GetReportById(postReportId);

            postReport.IsResolved = true;
            postReport.ResolvedOn = DateTime.UtcNow.ToString("MM/dd/yyyy h:mm tt");
            postReport.NormalizedResolvedOn = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            this.context.PostReports.Update(postReport);
            await this.context.SaveChangesAsync();
        }

        public IEnumerable<T> GetAllAdminResolved<T>()
            => this.context.PostReports
            .Where(x => x.IsResolved)
            .To<T>()
            .ToList();

        public IEnumerable<T> GetAllAdminUnresolved<T>()
            => this.context.PostReports
            .Where(x => !x.IsResolved)
            .To<T>()
            .ToList();

        public IEnumerable<T> GetAllByAccountResolved<T>(string accountId)
            => this.context.PostReports
            .Where(x => x.AccountId == accountId && x.IsResolved)
            .To<T>()
            .ToList();

        public IEnumerable<T> GetAllByAccountUnresolved<T>(string accountId)
            => this.context.PostReports
            .Where(x => x.AccountId == accountId && !x.IsResolved)
            .To<T>()
            .ToList();

        public T GetPostReportByIdGeneric<T>(string postReportId)
            => this.context.PostReports
            .Where(x => x.Id == postReportId)
            .To<T>()
            .FirstOrDefault();

        public PostReport GetReportById(string postReportId)
            => this.context.PostReports
            .FirstOrDefault(x => x.Id == postReportId);


    }
}
