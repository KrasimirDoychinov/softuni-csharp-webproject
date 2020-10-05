using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class Tag
    {
        public int Id { get; set; }

        // TODO: Add a max lenght (add a common)
        public string Name { get; set; }

        public ICollection<PostTag> Posts { get; set; } = new List<PostTag>(); 
    }
}