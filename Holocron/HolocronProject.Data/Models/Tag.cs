using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class Tag
    {
        // TODO: Implement services
        // TODO: Service to add tags to post
        // TODO: View services
        public Tag()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.TagConstants.NameMaxLength)]
        public string Name { get; set; }

        public virtual ICollection<PostTag> Posts { get; set; } = new List<PostTag>();
    }
}