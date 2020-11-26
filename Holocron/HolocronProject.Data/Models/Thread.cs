using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class Thread : BaseDeletableModel
    {
        // TODO: Implement services
        // TODO: Delete service
        // TODO: View services
        public Thread()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.ThreadConstants.TitleMaxLength)]
        public string Title { get; set; }

        [Required]

        public string Description { get; set; }

        [Required]
        public string BaseThreadId { get; set; }

        public virtual BaseThread BaseThread { get; set; }

        [Required]
        public string AccountId { get; set; }

        public virtual Account Account { get; set; }

        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

        public virtual ICollection<Vote> Votes { get; set; } = new List<Vote>();

    }
}
