﻿namespace HolocronProject.Data.Models
{
    public class PostTag
    {
        // TODO: Implement services
        // TODO: Check to be sure
        public string PostId { get; set; }

        public Post Post { get; set; }

        public string TagId { get; set; }

        public Tag Tag { get; set; }
    }
}
