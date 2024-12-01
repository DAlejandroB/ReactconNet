using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReactConNetApi.Models;

namespace ReactConNetApi.Data
{
    public class SocialMediaContext(DbContextOptions options) : IdentityDbContext<User, IdentityRole<Guid>, Guid>(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
    }
}
