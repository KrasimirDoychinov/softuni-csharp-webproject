using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Identity;

using HolocronProject.Data.Enums;

namespace HolocronProject.Data.Models
{

    public class Account : IdentityUser
    {
        public Account()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public bool IsBanned { get; set; } = false;

        public DateTime BannedOn { get; set; }

        public string AvatarImagePath { get; set; } 

        public string ForumSignature { get; set; }

        public virtual ICollection<Character> Characters { get; set; } = new List<Character>();

        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

        public virtual ICollection<Thread> Threads { get; set; } = new List<Thread>();

        public virtual ICollection<BugReport> BugReports { get; set; } = new List<BugReport>();

        public virtual ICollection<PostReport> PostReports { get; set; } = new List<PostReport>();

        public NotificationStatus NotificationStatus { get; set; } = 0;

    }
}
