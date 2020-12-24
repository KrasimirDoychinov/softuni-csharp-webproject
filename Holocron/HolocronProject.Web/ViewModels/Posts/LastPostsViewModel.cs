using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Posts
{
    public class LastPostsViewModel : PostViewModel
    {
        public string ThreadId { get; set; }

        public string ThreadTitle { get; set; }

        public int TotalPosts { get; set; }

        public int PostsMadeToday { get; set; }

        public int DeletedPosts { get; set; }

        public DateTime DeletedOn { get; set; }

        public string NormalizedDeletedOn => this.DeletedOn.ToLocalTime().ToString("MM/dd/yyyy h:mm tt");

        public bool AccountIsBanned { get; set; }

        public int NotDeletedPosts { get; set; }

        public string ShortedThreadTitle => this.ThreadTitle.Length <= 50 ? this.ThreadTitle : this.ThreadTitle.Substring(0, 50) + "...";

        public Pager.Pager Pager { get; set; }
    }
}
