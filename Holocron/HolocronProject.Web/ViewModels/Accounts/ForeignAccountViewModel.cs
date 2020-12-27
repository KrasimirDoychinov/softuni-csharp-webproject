using System;

using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.Accounts
{
    public class ForeignAccountViewModel : IMapFrom<Account>
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public DateTime CreatedOn { get; set; }

        public string AvatarImagePath { get; set; }

        public int PostsCount { get; set; }

        public int ThreadsCount { get; set; }

        public string Role { get; set; }
    }
}
