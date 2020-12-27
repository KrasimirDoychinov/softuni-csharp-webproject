using System;
using System.Linq;
using System.Collections.Generic;

using Ganss.XSS;

using AutoMapper;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Posts;

namespace HolocronProject.Web.ViewModels.Threads
{
    public class ThreadViewModel : IMapFrom<Thread>, IHaveCustomMappings
    {
        public string Id { get; set; }

        public string AccountId { get; set; }

        public string AccountUserName { get; set; }

        public string AccountAvatarImagePath { get; set; }

        public string AccountForumSignature { get; set; }

        public string SanitizedForumSignature => new HtmlSanitizer().Sanitize(this.AccountForumSignature);

        public string Title { get; set; }

        public string ShortenedTitle => this.Title.Length <= 50 ? this.Title : this.Title.Substring(0, 50) + "...";

        public DateTime CreatedOn { get; set; }

        public int PostsCount { get; set; }

        public string Description { get; set; }

        public string SanitizedDescription { get; set; }

        public IEnumerable<PostViewModel> Posts { get; set; }

        public int VotesCount { get; set; }

        public Pager.Pager Pager { get; set; }

        public string ControllerName => "Threads";

        public string ActionName => "ById";

        public string QueryId => "threadId";

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
