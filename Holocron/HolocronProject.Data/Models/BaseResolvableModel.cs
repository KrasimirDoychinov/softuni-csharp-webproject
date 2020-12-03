﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class BaseResolvableModel
    {
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public string NormalizedCreatedOn { get; set; } = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");

        public bool IsResolved { get; set; } = false;

        public DateTime ResolvedOn { get; set; }

        public string NormalizedResolvedOn { get; set; }
    }
}
