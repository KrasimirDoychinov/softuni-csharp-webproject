using System;

namespace HolocronProject.Data.Models
{
    public abstract class BaseDeletableModel
    {
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public DateTime NormalizedCreatedOn { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTime DeletedOn { get; set; }

        public DateTime NormalizedDeletedOn { get; set; }
    }
}
