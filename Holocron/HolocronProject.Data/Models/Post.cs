using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class Post
    {

        public int Id { get; set; }

        [MaxLength(GlobalConstants.PostConstants.TitleMaxLength)]
        public string Title { get; set; }

        [MaxLength(GlobalConstants.PostConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        public string ShortDescription
        {
            get
            {
                return this.Description.Substring(0, 50);
            }
        }

        public string CreatedOn { get; set; } = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

        public int AccountId { get; set; }

        public Account Account { get; set; }

        public int ThreadId { get; set; }

        public Thread Thread { get; set; }

        public ICollection<PostTag> Tags { get; set; } = new List<PostTag>();

    }
}
