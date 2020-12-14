using HolocronProject.Data.Enums;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Achievements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Characters
{
    public class CharacterUserViewModel : IMapFrom<Data.Models.Character>
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string CharacterType { get; set; }

        public ForceAffiliation ForceAffiliation { get; set; }

        public IEnumerable<AchievementViewModel> Achievements { get; set; } = new List<AchievementViewModel>();

        public string ForceAffiliationString { get; set; }

        public string AchievementsCount { get; set; }

        public string CompetitionsCount { get; set; }

        public string RaceName { get; set; }

        public string ServerName { get; set; }

        public string ClassName { get; set; }

        public string ClassFaction { get; set; }

        public string Description { get; set; }

        public string Backstory { get; set; }

        public string CharacterImagePath { get; set; }

        public string AccountUserName { get; set; }

        public string AccountId { get; set; }

        public bool IsApproved { get; set; }

        public DateTime CreatedOn { get; set; }

        public string NormalizedCreatedOn { get; set; }
    }
}
