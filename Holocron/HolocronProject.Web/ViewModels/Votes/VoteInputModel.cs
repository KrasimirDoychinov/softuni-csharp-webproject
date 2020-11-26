using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Votes
{
    public class VoteInputModel
    {
        public string ThreadId { get; set; }

        public bool IsUpVote { get; set; }
    }
}
