using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using HolocronProject.Data.Common;

namespace HolocronProject.Data.Models
{
    public class Tag
    {
        public int Id { get; set; }

        [MaxLength(GlobalConstants.TagConstants.NameMaxLength)]
        public string Name { get; set; }

        public ICollection<PostTag> Posts { get; set; } = new List<PostTag>(); 
    }
}