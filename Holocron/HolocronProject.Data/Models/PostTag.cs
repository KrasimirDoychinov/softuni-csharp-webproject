using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class PostTag
    {
        public int PostId { get; set; }

        public Post Post { get; set; }

        public int TagId { get; set; }

        public Tag Tag { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
