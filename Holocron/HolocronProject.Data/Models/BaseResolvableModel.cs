using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class BaseResolvableModel
    {
        public bool IsResolved { get; set; } = false;

        public DateTime? ResolvedDate { get; set; }
    }
}
