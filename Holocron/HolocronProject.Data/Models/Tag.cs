using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class Tag
    {
        public Tag()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.TagConstants.NameMaxLength)]
        public string Name { get; set; }

        public ICollection<PostTag> Posts { get; set; } = new List<PostTag>();
    }
}