using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Posts
{
    public class PostCountViewModel : IMapFrom<Post>
    {
        public bool IsDeleted { get; set; }
    }
}
