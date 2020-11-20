using HolocronProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class VoteThread
    {
        public VoteThread()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string ThreadId { get; set; }

        public Thread Thread { get; set; }

        [Required]
        public string AccountId { get; set; }

        public  Account Account { get; set; }

        public VoteType Type { get; set; }
    }
}

