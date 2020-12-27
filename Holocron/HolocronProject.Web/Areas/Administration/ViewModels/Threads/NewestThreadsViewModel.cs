using System;

using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Threads;

namespace HolocronProject.Web.Areas.Administration.ViewModels.Threads
{
    public class NewestThreadsViewModel : ThreadViewModel, IMapFrom<Thread>
    {
        public int TotalThreads { get; set; }

        public int ThreadsMadeToday { get; set; }

        public int DeletedThreads { get; set; }

        public int NotDeletedThreads { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime DeletedOn { get; set; }

        public bool AccountIsBanned { get; set; }
    }
}
