using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Web.ViewModels.Threads
{
    public class ThreadEditModel : ThreadInputModel, IMapFrom<Thread>
    {
        public string ThreadId { get; set; }
    }
}
