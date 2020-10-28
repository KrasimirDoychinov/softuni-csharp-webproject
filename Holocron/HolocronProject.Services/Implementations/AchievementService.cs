using HolocronProject.Data;
using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services.Implementations
{
    public class AchievementService : IAchievementService
    {
        private readonly HolocronDbContext context;
        private readonly ICompetitionService competitionService;

        public AchievementService(HolocronDbContext context, 
            ICompetitionService competitionService)
        {
            this.context = context;
            this.competitionService = competitionService;
        }

        public async Task CreateAchievement(string competitionId)
        {
            var competition = this.competitionService.GetCompetitionById(competitionId);

            var achievementFirst = new Achievement
            {
                Name = $"First place - {competition.Title}",
                CompetitionId = competitionId
            };

            var achievementSecond = new Achievement
            {
                Name = $"Second place - {competition.Title}",
                CompetitionId = competitionId
            };

            var achievementThird = new Achievement
            {
                Name = $"Third place - {competition.Title}",
                CompetitionId = competitionId
            };


            await this.context.Achievements.AddAsync(achievementFirst);
            await this.context.Achievements.AddAsync(achievementSecond);
            await this.context.Achievements.AddAsync(achievementThird);
            await this.context.SaveChangesAsync();
        }
    }
}
