using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Common;
using Microsoft.AspNetCore.Identity;

namespace HolocronProject.Data.Models
{

    public class Account : IdentityUser
    {
        // TODO: Editting account info
        public Account()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        
        public string CreatedOn { get; set; } = DateTime.UtcNow.ToString("MM/dd/yyyy h:mm tt");

        public string AvatarImagePath { get; set; } 

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
