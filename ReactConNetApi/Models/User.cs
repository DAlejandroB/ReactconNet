using Microsoft.AspNetCore.Identity;

namespace ReactConNetApi.Models
{
    public class User : IdentityUser<Guid>
    {
        public DateTime CreationTimestamp { get; set; } = DateTime.Now;
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<Reaction> Reactions { get; set; } = new List<Reaction>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
