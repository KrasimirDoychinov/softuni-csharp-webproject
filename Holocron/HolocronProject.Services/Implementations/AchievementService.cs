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

        public AchievementService(HolocronDbContext context)
        {
            this.context = context;
        }

        public async Task CreateAchievement(string name, string competitionId)
        {
            var achievement = new Achievement
            {
                Name = name,
                CompetitionId = competitionId
            };

            await this.context.Achievements.AddAsync(achievement);
            await this.context.SaveChangesAsync();
        }
    }
}
