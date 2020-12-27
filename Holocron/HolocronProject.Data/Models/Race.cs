using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HolocronProject.Data.Models
{
    public class Race
    {
        public Race()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Character> Characters { get; set; } = new List<Character>();

    }
}
