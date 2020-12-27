namespace HolocronProject.Services.Models
{
    public class ForeignAccountDto
    {
        public string Id { get; set; }

        public string DisplayName { get; set; }

        public string CreatedOn { get; set; }

        public string AvatarImage { get; set; }

        public int CharactersCount { get; set; }

        public int PostsCount { get; set; }

        public int ThreadsCount { get; set; }

        public int BugReportsCount { get; set; }

        public int PostReportsCount { get; set; }

    }
}
