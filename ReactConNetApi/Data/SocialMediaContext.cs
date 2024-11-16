using Microsoft.EntityFrameworkCore;
using ReactConNetApi.Models;

namespace ReactConNetApi.Data
{
    public class SocialMediaContext : DbContext
    {
        public SocialMediaContext(DbContextOptions<SocialMediaContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

    }
}
