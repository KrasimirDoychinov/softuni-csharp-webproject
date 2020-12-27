using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.Achievements
{
    public class AchievementViewModel : IMapFrom<Achievement>
    {
        public string Name { get; set; }

        public string CompetitionName { get; set; }
    }
}
