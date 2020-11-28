﻿using HolocronProject.Data;
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
        private readonly HolocronDbContext context;

        public BugReportsService(HolocronDbContext context)
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
            var bugReport = GetReportById(bugReportId);

            bugReport.IsResolved = true;
            bugReport.ResolvedOn = DateTime.UtcNow.ToString("MM/dd/yyyy h:mm tt");
            bugReport.NormalizedResolvedOn = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            this.context.BugReports.Update(bugReport);
            await this.context.SaveChangesAsync();
        }

        public T GetBugReportByIdGeneric<T>(string bugReportId)
            => this.context.BugReports
            .Where(x => x.Id == bugReportId)
            .To<T>()
            .FirstOrDefault();

        public IEnumerable<T> GetAllByAccountUnresolved<T>(string accountId)
            => this.context.BugReports
            .Where(x => x.AccountId == accountId && x.IsResolved == false)
            .OrderBy(x => x.CreatedOn)
            .To<T>()
            .ToList();

        public IEnumerable<T> GetAllByAccountResolved<T>(string accountId)
            => this.context.BugReports
            .Where(x => x.AccountId == accountId && x.IsResolved == true)
            .OrderBy(x => x.ResolvedOn)
            .To<T>()
            .ToList();

        public IEnumerable<T> GetAllAdminUnresolved<T>()
            => this.context.BugReports
            .Where(x => x.IsResolved == false)
            .OrderBy(x => x.CreatedOn)
            .To<T>()
            .ToList();

        public IEnumerable<T> GetAllAdminResolved<T>()
            => this.context.BugReports
            .Where(x => x.IsResolved == true)
            .OrderBy(x => x.ResolvedOn)
            .To<T>()
            .ToList();

        public BugReport GetReportById(string bugReportId)
            => this.context.BugReports
            .FirstOrDefault(x => x.Id == bugReportId);
    }
}