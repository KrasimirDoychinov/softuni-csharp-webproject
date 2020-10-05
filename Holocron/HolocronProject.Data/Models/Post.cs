using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class Post
    {
        private string shortDescription;
        
        public int Id { get; set; }

        // TODO: Add max length (add a common)
        public string Title { get; set; }

        // TODO: Add max length (add a common)
        public string Description { get; set; }

        // TODO: Add max length (add a common)
        public string ShortDescription
        {
            get
            {
                return this.shortDescription;
            }

            set
            {
                this.shortDescription = this.Description.Substring(0, 50);
            }
        }

        public int AccountId { get; set; }

        public Account Account { get; set; }

        public int ThreadId { get; set; }

        public Thread Thread { get; set; }

        public ICollection<PostTag> Tags { get; set; } = new List<PostTag>();

        
    }
}
