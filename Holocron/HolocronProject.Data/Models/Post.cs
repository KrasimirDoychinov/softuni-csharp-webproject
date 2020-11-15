using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class Post : BaseDeletableModel
    {
        // TODO: Implement service
        // TODO: Edit posts
        // TODO: Add tags
        // TODO: Delete post
        // TODO: View services
        public Post()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.PostConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        public string CreatedOn { get; set; } = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

        [Required]
        public string AccountId { get; set; }

        public Account Account { get; set; }

        [Required]
        public string ThreadId { get; set; }

        public Thread Thread { get; set; }

        public ICollection<PostTag> Tags { get; set; } = new List<PostTag>();

    }
}
