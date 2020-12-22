using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class CompetitionAccount : BaseDeletableModel
    {
        public string AccountId { get; set; }

        public virtual Account Account { get; set; }

        public string CompetitionId { get; set; }

        public virtual Competition Competition { get; set; }

        public bool HasVoted { get; set; }

        public string CompetitionCharacterId { get; set; }

        public virtual CompetitionCharacter CompetitionCharacter { get; set; }
    }
}
