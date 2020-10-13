using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class Post
    {
        public Post()
        {

        }

        public int Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.PostConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        public string CreatedOn { get; set; } = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

        public int AccountId { get; set; }

        public Account Account { get; set; }

        public int ThreadId { get; set; }

        public Thread Thread { get; set; }

        public ICollection<PostTag> Tags { get; set; } = new List<PostTag>();

        public bool IsDeleted { get; set; } = false;

    }
}
