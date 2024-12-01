namespace ReactConNetApi.Models
{
    public class Reaction
    {
        public Guid Id { get; set; }

        public Guid AuthorId { get; set; }
        public User Author { get; set; }

        public DateTime CreationTimestamp { get; set; } = DateTime.Now;
        public ReactionType ReactionType { get; set; }
    }

    public enum ReactionType
    {
        Like,
        Dislike
    }
}
