using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class BaseThread : BaseDeletableModel
    {
        // TODO: View services
        public BaseThread()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        public ICollection<Thread> Threads { get; set; } = new List<Thread>();

    }
}
