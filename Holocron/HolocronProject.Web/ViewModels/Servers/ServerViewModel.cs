using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.Servers
{
    public class ServerViewModel : IMapFrom<Server>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
