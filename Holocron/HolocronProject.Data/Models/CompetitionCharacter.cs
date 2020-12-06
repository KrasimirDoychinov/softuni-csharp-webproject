using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class CompetitionCharacter
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

        public virtual ICollection<CompetitionVote> Votes { get; set; } = new List<CompetitionVote>();
    }
}
