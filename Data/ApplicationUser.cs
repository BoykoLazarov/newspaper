using Microsoft.AspNetCore.Identity;
using NewsPaper.Models;

namespace NewsPaper.Data
{
    public class ApplicationUser : IdentityUser
    {
        public Juridical Juridical { get; set; }

        public Physical Physical { get; set; }

        public ICollection<Order> Orders { get; set; }

        public string Address { get; set; }
    }
}
