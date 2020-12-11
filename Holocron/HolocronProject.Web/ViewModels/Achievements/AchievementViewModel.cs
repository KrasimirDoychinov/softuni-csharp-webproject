using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Achievements
{
    public class AchievementViewModel : IMapFrom<Achievement>
    {
        public string Name { get; set; }

        public string CompetitionName { get; set; }
    }
}
