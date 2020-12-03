using System;

namespace HolocronProject.Data.Models
{
    public abstract class BaseDeletableModel
    {
        public string CreatedOn { get; set; } = DateTime.UtcNow.ToString("MM/dd/yyyy h:mm tt");

        public string NormalizedCreatedOn { get; set; } = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

        public bool IsDeleted { get; set; } = false;

        public string DeletedOn { get; set; }
    }
}
