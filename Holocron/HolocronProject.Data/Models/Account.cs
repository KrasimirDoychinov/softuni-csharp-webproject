using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class Account
    {
        public int Id { get; set; }

        // TODO: Add max length (add a common)
        public string AccountName { get; set; }

        // TODO: Add max length (add a common)
        public string Pasword { get; set; }

        // TODO: Add max length (add a common)
        public string DisplayName { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.UtcNow;

        // TODO: Need to figure out how to add an AvatarImage
        public string AvatarImage { get; set; } = "Placeholder Image";

        // TODO: Figure out how to add a forum signature
        // TODO: Add max length (add a common)
        public string ForumSignature { get; set; }

        public ICollection<Character> Characters { get; set; } = new List<Character>();

        public ICollection<Post> Posts { get; set; } = new List<Post>();

        public ICollection<AccountThread> Threads { get; set; } = new List<AccountThread>();

    }
}
