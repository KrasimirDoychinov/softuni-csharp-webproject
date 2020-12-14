using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class BaseResolvableModel
    {
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public DateTime NormalizedCreatedOn { get; set; }

        public bool IsResolved { get; set; } = false;

        public DateTime ResolvedOn { get; set; }

        public DateTime NormalizedResolvedOn { get; set; }
    }
}
