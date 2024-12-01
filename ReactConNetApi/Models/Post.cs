namespace ReactConNetApi.Models
{
    public class Post
    {
        public Guid Id { get; set; }

        public Guid AuthorId { get; set; }
        public User Author { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Reaction> Reactions { get; set; }
        public DateTime CreationTimestamp { get; set; } = DateTime.Now;
    }
}
