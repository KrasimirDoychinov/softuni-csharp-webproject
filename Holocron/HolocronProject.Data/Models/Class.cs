using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class Class
    {
        public int Id { get; set; }

        [MaxLength(GlobalConstants.ClassConstants.NameMaxLength)]
        public string Name { get; set; }

        public ICollection<Character> Characters { get; set; } = new List<Character>();
    }
}
