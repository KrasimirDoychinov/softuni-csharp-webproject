using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Servers
{
    public class ServerViewModel : IMapFrom<Server>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
