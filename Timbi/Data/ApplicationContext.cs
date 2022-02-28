using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timbi.Data.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                   : base(options)
        {
            Database.EnsureCreated();
        }
        //public DbSet<ServicesUser> ServicesUser { get; set; }
        //public DbSet<Company> Company { get; set; }
        //public DbSet<Main> Main { get; set; }
    }
}
