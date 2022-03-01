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
        public IEnumerable<Main> Main => ApplicationContext.Main;
    }
    
}
