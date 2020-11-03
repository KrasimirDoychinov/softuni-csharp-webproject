using HolocronProject.Data;
using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services.Implementations
{
    public class CompetitionService : ICompetitionService
    {
        private readonly HolocronDbContext context;
        private readonly IAchievementService achievementService;

        public CompetitionService(HolocronDbContext context, IAchievementService achievementService)
        {
            this.context = context;
            this.achievementService = achievementService;
        }


        public async Task CreateCompetition(string title, string description, DateTime startDate, DateTime endDate)
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
        }

        public Competition GetCompetitionById(string competitionId)
            => this.context.Competitions.FirstOrDefault(x => x.Id == competitionId);
    }
}
