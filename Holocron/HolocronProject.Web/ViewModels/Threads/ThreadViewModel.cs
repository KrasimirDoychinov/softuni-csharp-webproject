﻿using AutoMapper;
using Ganss.XSS;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public string CreatedOn { get; set; }

        public int PostsCount { get; set; }

        public string Description { get; set; }

        public string RandomImageQuery { get; set; }

        public IEnumerable<PostViewModel> Posts { get; set; }

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
