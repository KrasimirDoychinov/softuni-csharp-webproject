using System.Collections.Generic;

namespace HolocronProject.Data.Models
{
    public class Server
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Character> Characters { get; set; } = new List<Character>();

        public bool IsDeleted { get; set; } = false;
    }
}
