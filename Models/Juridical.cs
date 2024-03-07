using NewsPaper.Data;
using System.ComponentModel.DataAnnotations;

namespace NewsPaper.Models
{
    public class Juridical
    {
        [Key]
        public string UserId {  get; set; }

        public ApplicationIdentityUser User { get; set; }

        public string Company { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string? Role { get; set; }
    }
}
