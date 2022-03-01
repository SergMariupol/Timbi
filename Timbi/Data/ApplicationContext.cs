using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Timbi.Data.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                   : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Region> Region { get; set; }
        public DbSet<TypeService> TypeService { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Main> Main { get; set; }
    }
}
