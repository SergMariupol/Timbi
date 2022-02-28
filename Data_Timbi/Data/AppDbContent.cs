using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Timbi.Data.Models;

namespace Data_Timbi.Data
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
        {

        }
        public DbSet<ServicesUser> ServicesUser { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Main> Main { get; set; }
    }
}
