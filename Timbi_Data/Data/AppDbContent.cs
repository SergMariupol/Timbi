using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Timbi.Data.Models;

namespace Data_Timbi.Data
{
    public class AppDbContent : DbContext
    {
        //public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
        //{

        //}
        // Имя будущей базы данных можно указать через
        // вызов конструктора базового класса
        public AppDbContent() : base("DbTimbi")
        { 
        
        }

        // Отражение таблиц базы данных на свойства с типом DbSet
        public DbSet<ServicesUser> ServicesUser { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Main> Main { get; set; }
    }
}
