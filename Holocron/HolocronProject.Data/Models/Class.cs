using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class Class
    {
        public int Id { get; set; }

        // TODO: Add a max length (add a common)
        public string Name { get; set; }

        // TODO: Make a intermediate class
        public ICollection<Character> Characters { get; set; } = new List<Character>();
    }
}
