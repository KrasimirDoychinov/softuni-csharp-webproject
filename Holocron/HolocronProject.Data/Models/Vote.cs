using System.ComponentModel.DataAnnotations;

using HolocronProject.Data.Enums;

namespace HolocronProject.Data.Models
{
    public class Vote
    {
        [Required]
        public string ThreadId { get; set; }

        public virtual Thread Thread { get; set; }

        [Required]
        public string AccountId { get; set; }

        public virtual Account Account { get; set; }

        public VoteType Type { get; set; }
    }
}
