using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class BaseThread
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.BaseThreadConstants.TitleMaxLength)]
        public string Title { get; set; }

        public ICollection<Thread> Threads { get; set; } = new List<Thread>();

        public bool IsDeleted { get; set; } = false;
    }
}
