using Microsoft.AspNetCore.Identity;

namespace Bookify.Models.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public IList<Review> Reviews { get; set; } = new List<Review>();
        public IList<Rating> Ratings { get; set; } = new List<Rating>();
    }
}
