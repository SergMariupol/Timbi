using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timbi.Data.Models;

namespace Web_interface.Data
{
    public class AppDbContent : DbContext
    {
  public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<ServicesUser> ServicesUser { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Main> Main{ get; set; }
        //public DbSet<OrderDetail> OrderDetail { get; set; }


    }
}
