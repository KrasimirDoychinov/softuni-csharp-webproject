namespace HolocronProject.Data.Models
{
    public class PostTag
    {
        // TODO: Implement services
        // TODO: Check to be sure
        public string PostId { get; set; }

        public virtual Post Post { get; set; }

        public string TagId { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
