using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;
using HolocronProject.Data.Enums;
using Microsoft.AspNetCore.Identity;

namespace HolocronProject.Data.Models
{

    public class Account : IdentityUser
    {
        public Account()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

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
