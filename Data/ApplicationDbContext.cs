using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewsPaper.Models;

namespace NewsPaper.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Juridical> Juridicals { get; set; }

        public DbSet<Physical> Physicals { get; set; }

        public DbSet<Rubric> Rubrics { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Printing> Printings { get; set; }

        public DbSet<ContractStatus> ContractStatuses { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}