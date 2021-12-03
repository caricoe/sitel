using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sitel_test.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Models.Agent> Agent { get; set; }
        public DbSet<Models.Campaign> Campaign { get; set; }
        public DbSet<Models.Trainer> Trainer { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

    }
}