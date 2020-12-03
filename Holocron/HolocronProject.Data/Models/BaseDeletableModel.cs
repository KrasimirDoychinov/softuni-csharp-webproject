using System;

namespace HolocronProject.Data.Models
{
    public abstract class BaseDeletableModel
    {
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public string NormalizedCreatedOn { get; set; } = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");

        public bool IsDeleted { get; set; } = false;

        public DateTime DeletedOn { get; set; }

        public string NormalizedDeletedOn { get; set; }
    }
}
