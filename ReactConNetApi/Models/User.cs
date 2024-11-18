using Microsoft.AspNetCore.Identity;

namespace ReactConNetApi.Models
{
    public class User : IdentityUser
    {
        public DateTime CreationTimestamp { get; set; } = DateTime.Now;
    }
}
