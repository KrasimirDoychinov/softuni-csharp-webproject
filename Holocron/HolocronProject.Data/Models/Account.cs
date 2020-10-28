using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;


namespace HolocronProject.Data.Models
{

    public class Account
    {
        public Account()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.AccountConstants.AccountNameMaxLength)]
        public string AccountName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required] 
        [MaxLength(GlobalConstants.AccountConstants.DisplayNameMaxLength)]
        public string DisplayName { get; set; }

        public string CreatedOn { get; set; } = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

        // TODO: Add max length (add a common)
        // TODO: Need to figure out how to add an AvatarImage
        public string AvatarImage { get; set; } = "Placeholder Image";

        // ?TODA?: Figure out how to add a forum signature
        // ?TODA?: Add max length (add a common) 
        public string ForumSignature { get; set; } = "Placeholder forum signature";

        public ICollection<Character> Characters { get; set; } = new List<Character>();

        public ICollection<Post> Posts { get; set; } = new List<Post>();

        public ICollection<Thread> Threads { get; set; } = new List<Thread>();

        public ICollection<BugReport> BugReports { get; set; } = new List<BugReport>();

        public ICollection<PostReport> PostReports { get; set; } = new List<PostReport>();

    }
}
