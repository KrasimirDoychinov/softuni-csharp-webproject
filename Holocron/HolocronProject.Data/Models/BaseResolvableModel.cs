using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class BaseResolvableModel
    {
        public string CreatedOn { get; set; } = DateTime.UtcNow.ToString("MM/dd/yyyy h:mm tt");

        public bool IsResolved { get; set; } = false;

        public string ResolvedOn { get; set; }
    }
}
