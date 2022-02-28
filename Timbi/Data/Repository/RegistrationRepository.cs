using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timbi.Data.Interfaces;
using Timbi.Data.Models;

namespace Timbi.Data.Repository
{
    public class RegistrationRepository : IAllRegistration
    {
        private readonly AppDbContent appDBContent;

        //private readonly Register Register;

        public RegistrationRepository(AppDbContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public void CreateUser(User_ User)
        {
            appDBContent.User.Add(User);
            appDBContent.SaveChanges();
        }

        public IEnumerable<User_> UserList => appDBContent.User;
    }
}
