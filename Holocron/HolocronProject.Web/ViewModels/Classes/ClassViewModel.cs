using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.Classes
{
    public class ClassViewModel : IMapFrom<Class>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
