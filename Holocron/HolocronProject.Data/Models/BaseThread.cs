﻿using System;
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

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Thread> Threads { get; set; } = new List<Thread>();

        

    }
}
