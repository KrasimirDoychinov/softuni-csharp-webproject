using AutoMapper;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Threads
{
    public class ThreadViewModel : IMapFrom<Thread>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string AccountUserName { get; set; }

        public string Title { get; set; }

        public string CreatedOn { get; set; }

        public int PostsCount { get; set; }

        public string Description { get; set; }

        public int VotesCount { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Thread, ThreadViewModel>()
               .ForMember(x => x.VotesCount, options =>
               {
                   options.MapFrom(p => p.Votes.Sum(v => (int)v.Type));
               });
        }
    }
}
