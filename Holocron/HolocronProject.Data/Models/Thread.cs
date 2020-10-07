using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class Thread
    {
        public int Id { get; set; }

        [MaxLength(GlobalConstants.ThreadConstants.TitleMaxLength)]
        public string Title { get; set; }

        public int BaseThreadId { get; set; }

        public BaseThread BaseThread { get; set; }

        public string CreatedOn { get; set; } = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

        public ICollection<Post> Posts { get; set; } = new List<Post>();

        public ICollection<AccountThread> Accounts { get; set; } = new List<AccountThread>();
    }
}
