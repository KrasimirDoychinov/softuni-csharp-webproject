using AutoMapper;
using Ganss.XSS;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Posts
{
    public class PostViewModel : IMapFrom<Post>
    {
        public string Id { get; set; }

        public string CreatedOn { get; set; }

        public string Description { get; set; }

        public string SanitizedDescription { get; set; }

        public string AccountId { get; set; }

        public string AccountUserName { get; set; }

        public string AccountAvatarImagePath { get; set; }

        public string AccountForumSignature { get; set; }

        public string SanitizedForumSignature => new HtmlSanitizer().Sanitize(this.AccountForumSignature);

    }
}
