using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class Thread
    {
        public int Id { get; set; }

        // TODO: Add max length (add a common)
        public string Name { get; set; }

        // TODO: Add max length (add a common)
        public string Description { get; set; }

        public int BaseThreadId { get; set; }

        public BaseThread BaseThread { get; set; }

        public ICollection<Post> Posts { get; set; } = new List<Post>();

        public ICollection<AccountThread> Accounts { get; set; } = new List<AccountThread>();
    }
}
