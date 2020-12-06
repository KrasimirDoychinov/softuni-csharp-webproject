using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class CompetitionVote
    {
        public string AccountId { get; set; }

        public virtual Account Account { get; set; }

        public string CompetitionCharacterId { get; set; }

        public virtual CompetitionCharacter CompetitionCharacter { get; set; }

    }
}
