using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class CompetitionCharacter
    {
        // TODO: Make sure this works
        // TODO: Implement services
        // TODO: Service to increase votes
        // TODO: View services

        public string CompetitionId { get; set; }

        public Competition Competition { get; set; }

        public string CharacterId { get; set; }

        public Character Character { get; set; }

    }
}
