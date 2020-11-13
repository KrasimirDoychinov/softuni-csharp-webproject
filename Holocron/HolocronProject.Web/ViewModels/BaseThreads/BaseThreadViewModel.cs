using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.BaseThreads
{
    public class BaseThreadViewModel : IMapFrom<BaseThread>
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public int ThreadsCount { get; set; }
    }
}
