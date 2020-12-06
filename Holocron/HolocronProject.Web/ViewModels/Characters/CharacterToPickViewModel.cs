using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Characters
{
    public class CharacterToPickViewModel : CharacterListViewModel, IMapFrom<Character>
    {
        public string CompetitionId { get; set; }
    }
}
