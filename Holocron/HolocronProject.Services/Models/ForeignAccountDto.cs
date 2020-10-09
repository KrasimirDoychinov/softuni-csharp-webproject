using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Services.Models
{
    public class ForeignAccountDto
    {
        public string DisplayName { get; set; }

        public string AvatarImage { get; set; }

        public string CreatedOn { get; set; }

        public ICollection<Character> Characters { get; set; } = new List<Character>();

        public ICollection<Post> Posts { get; set; } = new List<Post>();

        public ICollection<Thread> Threads { get; set; } = new List<Thread>();

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Display name: {this.DisplayName}");
            sb.AppendLine($"Avatar image: {this.AvatarImage}");
            sb.AppendLine($"Created on: {this.CreatedOn}");
            sb.AppendLine(new string('#', 20));

            foreach (var character in this.Characters)
            {
                sb.AppendLine($"Name: {character.Name}");
                sb.AppendLine($"Race: {character.Race.Name}");
                sb.AppendLine($"Class: {character.Class}");
                sb.AppendLine($"Gender: {character.Gender}");
                sb.AppendLine($"Faction: {character.Faction}");
                sb.AppendLine($"Server: {character.Server.Name}");
                sb.AppendLine($"Image :{character.Image}");
                sb.AppendLine($"Title :{character.Title}");
                sb.AppendLine(new string('#', 20));
            }

            sb.AppendLine(new string('@', 20));

            foreach (var post in this.Posts)
            {
                sb.AppendLine($"Post description: {post.Description}");
                sb.AppendLine(new string('@', 20));
            }

            sb.AppendLine(new string('*', 20));

            foreach (var thread in this.Threads)
            {
                sb.AppendLine($"Thread title: {thread.Title}");
                sb.AppendLine(new string('*', 20));
            }

            return sb.ToString().TrimEnd();


        }

    }
}
