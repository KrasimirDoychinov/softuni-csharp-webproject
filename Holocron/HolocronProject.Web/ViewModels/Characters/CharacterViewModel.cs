using System.Collections.Generic;

using HolocronProject.Data.Enums;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Achievements;

namespace HolocronProject.Web.ViewModels.Characters
{
    public class CharacterViewModel : IMapFrom<Data.Models.Character>
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string CharacterType { get; set; }

        public ForceAffiliation ForceAffiliation { get; set; }

        public IEnumerable<AchievementViewModel> Achievements { get; set; } = new List<AchievementViewModel>();

        public string ForceAffiliationString { get; set; }

        public string RaceName { get; set; }

        public string ServerName { get; set; }

        public string ClassName { get; set; }

        public string Description { get; set; }

        public string Backstory { get; set; }

        public string CharacterImagePath { get; set; }

        public string AccountId { get; set; }

    }
}
