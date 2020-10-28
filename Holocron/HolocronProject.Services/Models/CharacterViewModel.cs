using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Services.Models
{
    public class CharacterViewModel
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public string CharacterType { get; set; }

        public string Faction { get; set; }

        public string ForceAffiliation { get; set; }

        public string Class { get; set; }

        public string RaceName { get; set; }

        public string ServerName { get; set; }

        public string AccountDisplayName { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Character owner: {this.AccountDisplayName}");
            sb.AppendLine($"Character name: {this.Name}");
            sb.AppendLine($"Gender: {this.Gender}");
            sb.AppendLine($"Type: {this.CharacterType}");
            sb.AppendLine($"Faction: {this.Faction}");
            sb.AppendLine($"Force affiliation: {this.ForceAffiliation}");
            sb.AppendLine($"Class: {this.Class}");
            sb.AppendLine($"Race: {this.RaceName}");
            sb.AppendLine($"Server: {this.ServerName}");

            return sb.ToString().TrimEnd();
        }
    }
}
