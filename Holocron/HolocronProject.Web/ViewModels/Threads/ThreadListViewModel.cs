
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.Threads
{
    public class ThreadListViewModel : ThreadViewModel, IMapFrom<Thread>
    {
        public bool IsDeleted { get; set; }
    }
}
