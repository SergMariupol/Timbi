using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timbi.Data.Models;

namespace Timbi.Data
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
        {
           
        }
        public DbSet<User_> User { get; set; }
        public DbSet<ServicesUser> ServicesUser { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Main> Main { get; set; }
        public DbSet<User> User_ { get; set; }


    }
}
