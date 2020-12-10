using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire;

namespace HolocronProject.Services.Implementations
{
    public class CompetitionsService : ICompetitionsService
    {
        private readonly HolocronDbContext context;
        private readonly IAchievementsService achievementService;

        public CompetitionsService(HolocronDbContext context, 
            IAchievementsService achievementService)
        {
            this.context = context;
            this.achievementService = achievementService;
        }


        public async Task<string> CreateCompetitionAsync(string title, string description, DateTime startDate, DateTime endDate)
        {
            var achievements = this.achievementService.CreateAchievement(title);

            var competition = new Competition
            {
                Title = title,
                Description = description,
                StartDate = startDate,
                EndDate = endDate,
                Achievements = achievements.ToList()
            };

            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            return competition.Id;
        }

        public async Task FinishCompetitionAsync(string competitionId)
        {
            var competition = GetCompetitionById(competitionId);

            competition.IsFinished = true;
            competition.FinishedOn = DateTime.UtcNow;

            await this.context.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll<T>()
            => this.context.Competitions
            .Where(x => !x.IsFinished)
            .To<T>()
            .ToList();

        public IEnumerable<T> GetAllFinished<T>()
            => this.context.Competitions
            .Where(x => x.IsFinished)
            .To<T>()
            .ToList();

        public Competition GetCompetitionById(string competitionId)
            => this.context.Competitions.FirstOrDefault(x => x.Id == competitionId);

        public T GetCompetitionByIdGeneric<T>(string competitionId)
            => this.context.Competitions
            .Where(x => x.Id == competitionId)
            .To<T>()
            .FirstOrDefault();

    }
}
