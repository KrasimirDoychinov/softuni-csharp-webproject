using HolocronProject.Data;
using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HolocronProject.Services.Implementations
{
    public class AchievementsService : IAchievementsService
    {
        private readonly ApplicationDbContext context;

        public AchievementsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Achievement> CreateAchievement(string title)
        {

            var achievementFirst = new Achievement
            {
                Name = $"First place - {title}"
            };

            var achievementSecond = new Achievement
            {
                Name = $"Second place - {title}"
            };

            var achievementThird = new Achievement
            {
                Name = $"Third place - {title}"
            };

            var list = new List<Achievement>
            {
                achievementFirst,
                achievementSecond,
                achievementThird
            };

            return list;
        }
    }
}
