using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using HolocronProject.Web.ViewModels.Pager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Areas.Administration.ViewModels.Accounts
{
    public class NewestAccountsViewModel : IMapFrom<Account>
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public DateTime CreatedOn { get; set; }

        public string NormalizedCreatedOn => this.CreatedOn.ToLocalTime().ToString("MM/dd/yyyy h:mm tt");

        public string AvatarImagePath { get; set; }

        public double RandomImageQuery => new Random().NextDouble();

        public Pager Pager { get; set; }
    }
}
