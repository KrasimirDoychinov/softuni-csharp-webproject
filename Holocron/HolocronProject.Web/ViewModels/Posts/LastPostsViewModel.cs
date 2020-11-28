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

        public string ShortedThreadTitle => this.ThreadTitle.Length <= 50 ? this.ThreadTitle : this.ThreadTitle.Substring(0, 50) + "...";

        public Pager.Pager Pager { get; set; }
    }
}
