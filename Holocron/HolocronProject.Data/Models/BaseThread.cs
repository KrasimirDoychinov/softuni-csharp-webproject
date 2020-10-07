﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class BaseThread
    {
        public int Id { get; set; }

        [MaxLength(GlobalConstants.BaseThreadConstants.NameMaxLength)]
        public string Name { get; set; }

        [MaxLength(GlobalConstants.BaseThreadConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        public ICollection<Thread> Threads { get; set; } = new List<Thread>();
    }
}
