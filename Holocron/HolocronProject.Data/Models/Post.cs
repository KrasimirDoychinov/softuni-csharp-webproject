﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class Post
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
        [MaxLength(GlobalRangeConstants.PostConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        public string CreatedOn { get; set; } = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

        public string AccountId { get; set; }

        public Account Account { get; set; }

        public string ThreadId { get; set; }

        public Thread Thread { get; set; }

        public ICollection<PostTag> Tags { get; set; } = new List<PostTag>();

        public bool IsDeleted { get; set; } = false;
    }
}
