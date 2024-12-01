namespace ReactConNetApi.Models
{
    public class Comment
    {
        public Guid Id { get; set; }

        public Guid AuthorId { get; set; }
        public User Author { get; set; }

        public Guid PostId { get; set; }
        public Post Post { get; set; }

        public string Content { get; set; }
        public DateTime CreationTimestamp { get; set; } = DateTime.Now;

    }
}
