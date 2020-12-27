using System.Collections.Generic;

using HolocronProject.Data.Models;

namespace HolocronProject.Services.Implementations
{
    public class AchievementsService : IAchievementsService
    {
        public AchievementsService()
        {

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
