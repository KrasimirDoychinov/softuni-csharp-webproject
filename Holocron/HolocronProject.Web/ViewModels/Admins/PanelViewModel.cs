using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Admins
{
    public class PanelViewModel 
    {
        public int TotalCharacters { get; set; }

        public int TotalAccounts { get; set; }

        public int TotalPosts { get; set; }

        public int TotalThreads { get; set; }

        public int TotalUnresolvedBugReports { get; set; }

        public int TotalUnresolvedPostReports { get; set; }
    }
}
