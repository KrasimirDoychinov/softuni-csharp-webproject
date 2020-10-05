using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class BaseThread
    {
        public int Id { get; set; }

        // TODO: Add max length (add a common)
        public string Name { get; set; }

        // TODO: Add max length (add a common)
        public string Description { get; set; }

        public ICollection<Thread> Threads { get; set; } = new List<Thread>();
    }
}
