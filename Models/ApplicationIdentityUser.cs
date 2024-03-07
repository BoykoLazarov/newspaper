using Microsoft.AspNetCore.Identity;

namespace NewsPaper.Models
{
    public class ApplicationIdentityUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
