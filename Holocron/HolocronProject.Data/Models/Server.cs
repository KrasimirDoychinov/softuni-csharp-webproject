using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HolocronProject.Data.Models
{
    public class Server
    {
        public Server()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Character> Characters { get; set; } = new List<Character>();

        public bool IsDeleted { get; set; } = false;
    }
}
