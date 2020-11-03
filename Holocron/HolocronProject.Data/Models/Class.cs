
using HolocronProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HolocronProject.Data.Models
{
    public class Class
    {
        // TODO: View services
        public Class()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public ICollection<Character> Characters { get; set; } = new List<Character>();

        public Faction Faction { get; set; }
    }
}
