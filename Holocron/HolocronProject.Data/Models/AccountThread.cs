
using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Data.Models
{
    public class AccountThread
    {
        public int AccountId { get; set; }

        public Account Account { get; set; }

        public int ThreadId { get; set; }

        public Thread Thread { get; set; }
    }
}
