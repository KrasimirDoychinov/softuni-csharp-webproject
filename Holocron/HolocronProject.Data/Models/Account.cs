using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using HolocronProject.Data.Common;


namespace HolocronProject.Data.Models
{

    // TODO: Fix the passwords!
    public class Account
    {
        public int Id { get; set; }

        [MaxLength(GlobalConstants.AccountConstants.AccountNameMaxLength)]
        public string AccountName { get; set; }

        [MaxLength(GlobalConstants.AccountConstants.PasswordMaxLength)]
        public string Password { get; set; }

        [MaxLength(GlobalConstants.AccountConstants.DisplayNameMaxLength)]
        public string DisplayName { get; set; }

        public string CreatedOn { get; set; } = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

        // TODO: Add max length (add a common)
        // TODO: Need to figure out how to add an AvatarImage
        public string AvatarImage { get; set; } = "Placeholder Image";

        // ?TODO?: Figure out how to add a forum signature
        // ?TODO?: Add max length (add a common) 
        public string ForumSignature { get; set; }

        public ICollection<Character> Characters { get; set; } = new List<Character>();

        public ICollection<Post> Posts { get; set; } = new List<Post>();

        public ICollection<Thread> Threads { get; set; } = new List<Thread>();

        public bool IsDeleted { get; set; } = false;

    }
}
