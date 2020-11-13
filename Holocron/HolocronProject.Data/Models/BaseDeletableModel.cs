using System;

namespace HolocronProject.Data.Models
{
    public abstract class BaseDeletableModel
    {
        public bool IsDeleted { get; set; } = false;

        public DateTime? DeletedOn { get; set; }
    }
}
