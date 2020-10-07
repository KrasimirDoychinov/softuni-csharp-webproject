using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class Server
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Character> Characters { get; set; } = new List<Character>();
    }
}
