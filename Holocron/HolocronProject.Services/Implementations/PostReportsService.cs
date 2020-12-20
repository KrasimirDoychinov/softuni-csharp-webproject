using AutoMapper;
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
        private readonly ApplicationDbContext context;
        private readonly IPostsService postsService;

        public PostReportsService(ApplicationDbContext context,
            IPostsService postsService)
        {
            this.postsService = postsService;
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
            var postReport = this.GetPostReportById(postReportId);

            postReport.IsResolved = true;
            postReport.ResolvedOn = DateTime.UtcNow;
            
            await this.context.SaveChangesAsync();
        }

        public async Task DeletePostReportAsync(string postReportid)
        {
            var postReport = this.GetPostReportById(postReportid);
            
            postReport.IsResolved = true;
            postReport.ResolvedOn = DateTime.UtcNow;

            await this.postsService.DeletePostAsync(postReport.PostId);
            await this.context.SaveChangesAsync();
        }

        public PostReport GetPostReportById(string postReportId)
            => this.context.PostReports
            .FirstOrDefault(x => x.Id == postReportId);

        public int TotalUnresolvedPostReports()
            => this.context.PostReports
            .Where(x => !x.IsResolved)
            .Count();

        public IEnumerable<T> GetAllAdminResolved<T>(IMapper mapper = null)
            => this.context.PostReports
            .Where(x => x.IsResolved)
            .OrderByDescending(x => x.ResolvedOn)
            .To<T>(mapper)
            .ToList();

        public IEnumerable<T> GetAllAdminUnresolved<T>(IMapper mapper = null)
            => this.context.PostReports
            .Where(x => !x.IsResolved)
            .OrderByDescending(x => x.CreatedOn)
            .To<T>(mapper)
            .ToList();

        public IEnumerable<T> GetAllByAccountResolved<T>(string accountId, IMapper mapper = null)
            => this.context.PostReports
            .Where(x => x.AccountId == accountId && x.IsResolved)
            .OrderByDescending(x => x.ResolvedOn)
            .To<T>(mapper)
            .ToList();

        public IEnumerable<T> GetAllByAccountUnresolved<T>(string accountId, IMapper mapper = null)
            => this.context.PostReports
            .Where(x => x.AccountId == accountId && !x.IsResolved)
            .OrderByDescending(x => x.CreatedOn)
            .To<T>(mapper)
            .ToList();

        public T GetPostReportByIdGeneric<T>(string postReportId, IMapper mapper = null)
            => this.context.PostReports
            .Where(x => x.Id == postReportId)
            .To<T>(mapper)
            .FirstOrDefault();
    }
}
