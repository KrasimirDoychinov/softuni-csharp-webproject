using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.CompetitionCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Competitions
{
    public class CompetitionViewModel : CompetitionListViewModel, IMapFrom<Competition>
    {
        public IEnumerable<CompetitionCharactersViewModel> Characters { get; set; }

        public bool IsFinished { get; set; }

        public bool DoesAccountVoteExist { get; set; }

        public bool HasAccountVoted { get; set; }

        public string ControllerName => "Competitions";

        public string ActionName => "ById";

        public string QueryId => "competitionId";
    }
}
