using System;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class Post : BaseDeletableModel
    {
        public Post()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(GlobalRangeConstraints.PostConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public string AccountId { get; set; }

        public virtual Account Account { get; set; }

        [Required]
        public string ThreadId { get; set; }

        public virtual Thread Thread { get; set; }


    }
}
