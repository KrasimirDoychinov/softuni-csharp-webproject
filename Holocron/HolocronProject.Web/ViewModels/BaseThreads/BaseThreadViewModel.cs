using AutoMapper;
using Ganss.XSS;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Threads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.BaseThreads
{
    public class BaseThreadViewModel : IMapFrom<BaseThread>, IHaveCustomMappings
    {

        public string Id { get; set; }

        public string Title { get; set; }

        public int ThreadsCount { get; set; }

        public int ThreadsPostsCount { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public IEnumerable<ThreadListViewModel> Threads { get; set; }

        public Pager.Pager Pager { get; set; }

        public string ControllerName => "BaseThreads";

        public string ActionName => "ById";

        public string QueryId => "threadId";

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<BaseThread, BaseThreadViewModel>()
               .ForMember(x => x.ThreadsCount, options =>
               {
                   options.MapFrom(p => p.Threads.Where(x => !x.IsDeleted).Count());
               });

        }
    }
}
