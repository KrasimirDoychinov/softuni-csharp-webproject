using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Services.Models
{
    public class AccountViewModel
    {
        public string DisplayName { get; set; }

        public string CreatedOn { get; set; }

        public string AvatarImage { get; set; }

        public int CharactersCount { get; set; }

        public int PostsCount { get; set; }

        public int ThreadsCount { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Display name: {this.DisplayName}");
            sb.AppendLine($"Created on: {this.CreatedOn}");
            sb.AppendLine($"Avatar image: {this.AvatarImage}");
            sb.AppendLine($"Characters count: {this.CharactersCount}");
            sb.AppendLine($"Posts count: {this.PostsCount}");
            sb.AppendLine($"Threads counts: {this.ThreadsCount}");

            return sb.ToString().TrimEnd();
        }

    }
}
