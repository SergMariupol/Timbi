﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timbi.Data.Models;

namespace Timbi.Data.Interfaces
{
    public interface IAllRegistration
    {
        void CreateUser(User User);

        //IEnumerable<User> RegistrationList { get; }       
    }
}
