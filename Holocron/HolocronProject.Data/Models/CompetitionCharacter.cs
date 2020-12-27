using System;
using System.Collections.Generic;

namespace HolocronProject.Data.Models
{
    public class CompetitionCharacter : BaseDeletableModel
    {
        public CompetitionCharacter()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string CompetitionId { get; set; }

        public virtual Competition Competition { get; set; }

        public string CharacterId { get; set; }

        public virtual Character Character { get; set; }

        public int Votes { get; set; }

        public virtual ICollection<CompetitionAccount> CompetitionAccounts { get; set; } = new List<CompetitionAccount>();
    }
}
