using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReactConNetApi.Models;

namespace ReactConNetApi.Data
{
    public class SocialMediaContext : IdentityDbContext
    {
        public SocialMediaContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }

    }
}
