using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Threads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public string NormalizedDeletedOn => this.DeletedOn.ToLocalTime().ToString("MM/dd/yyyy h:mm tt");

        public bool AccountIsBanned { get; set; }
    }
}
