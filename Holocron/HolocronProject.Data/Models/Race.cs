using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HolocronProject.Data.Models
{
    public class Race
    {
        public Race(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Character> Characters { get; set; } = new List<Character>();

    }
}
