using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class CompetitionCharacter
    {
        public string CompetitionId { get; set; }

        public Competition Competition { get; set; }

        public string CharacterId { get; set; }

        public Character Character { get; set; }

        public int Votes { get; set; }
    }
}
