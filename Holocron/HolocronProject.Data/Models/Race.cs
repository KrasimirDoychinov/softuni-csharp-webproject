using System.Collections.Generic;

namespace HolocronProject.Data.Models
{
    public class Race
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Character> Characters { get; set; } = new List<Character>();

    }
}
