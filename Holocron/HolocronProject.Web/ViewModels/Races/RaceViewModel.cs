using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.Races
{
    public class RaceViewModel : IMapFrom<Race>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
