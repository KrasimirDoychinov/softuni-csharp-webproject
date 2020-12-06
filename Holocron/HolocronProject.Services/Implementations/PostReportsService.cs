using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Services.Implementations
{
    public class PostReportsService : IPostReportsService
    {
        private readonly HolocronDbContext context;
        private readonly IPostsService postsService;

        public PostReportsService(HolocronDbContext context,
            IPostsService postsService)
        {
            this.context = context;
            this.postsService = postsService;
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
            postReport.ResolvedOn = DateTime.UtcNow;
            postReport.NormalizedResolvedOn = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            this.context.PostReports.Update(postReport);
            await this.context.SaveChangesAsync();
        }

        public async Task DeletePostReportAsync(string postReportid, string postId)
        {
            var postReport = this.GetReportById(postReportid);
            
            postReport.IsResolved = true;
            postReport.ResolvedOn = DateTime.UtcNow;
            postReport.NormalizedResolvedOn = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            await this.postsService.DeletePostAsync(postId);
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

        public int TotalUnresolvedPostReports()
            => this.context.PostReports
            .Where(x => !x.IsResolved)
            .OrderByDescending(x => x.CreatedOn)
            .Count();

    }
}
