using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IAchievementService
    {
        IEnumerable<Achievement> CreateAchievement(string competitionId);
    }
}
