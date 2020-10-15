
using HolocronProject.Data.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HolocronProject.Data.Models
{
    public class Class
    {
        public Class(string name, Faction faction)
        {
            this.Name = name;
            this.Faction = faction;

        }
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public IEnumerable<Character> Characters { get; set; } = new List<Character>();

        public Faction Faction { get; set; }
    }
}
