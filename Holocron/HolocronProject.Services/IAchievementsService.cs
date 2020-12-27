using System.Collections.Generic;

using HolocronProject.Data.Models;

namespace HolocronProject.Services
{
    public interface IAchievementsService
    {
        IEnumerable<Achievement> CreateAchievement(string title);
    }
}
