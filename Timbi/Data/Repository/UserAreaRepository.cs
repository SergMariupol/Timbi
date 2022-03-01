using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timbi.Data.Models;
using Timbi.Data.Interfaces;

namespace Timbi.Data.Repository
{
    public class UserAreaRepository : IAllUserArea
    {
        private readonly ApplicationContext ApplicationContext;
        public UserAreaRepository(ApplicationContext ApplicationContext)
        {
            this.ApplicationContext = ApplicationContext;
        }
        public IEnumerable<Region> Region => ApplicationContext.Region;
        public IEnumerable<TypeService> TypeService => ApplicationContext.TypeService;
        public IEnumerable<Main> Main => ApplicationContext.Main;
        public IEnumerable<Company> Company => ApplicationContext.Company;
    }
    
}
