namespace HolocronProject.Data.Models
{
    public class PostTag
    {
        public string PostId { get; set; }

        public Post Post { get; set; }

        public string TagId { get; set; }

        public Tag Tag { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
