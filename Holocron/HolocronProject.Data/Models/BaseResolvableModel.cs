using System;

namespace HolocronProject.Data.Models
{
    public class BaseResolvableModel
    {
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public bool IsResolved { get; set; } = false;

        public DateTime ResolvedOn { get; set; }
    }
}
