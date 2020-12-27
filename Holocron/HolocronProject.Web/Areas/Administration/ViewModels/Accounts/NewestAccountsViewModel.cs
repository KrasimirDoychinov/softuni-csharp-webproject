using System;

using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Pager;

namespace HolocronProject.Web.Areas.Administration.ViewModels.Accounts
{
    public class NewestAccountsViewModel : IMapFrom<Account>
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsBanned { get; set; }

        public DateTime BannedOn { get; set; }

        public string AvatarImagePath { get; set; }

        public Pager Pager { get; set; }

        public int TotalAccounts { get; set; }

        public int BannedAccounts { get; set; }

        public int NotBannedAccounts { get; set; }

        public int AccountsMadeToday { get; set; }

        public int ConfirmedAccounts { get; set; }

        public int PendingAccounts { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }
    }
}
