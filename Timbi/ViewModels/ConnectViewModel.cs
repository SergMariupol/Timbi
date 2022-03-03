using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timbi.Data.Models;

namespace Timbi.ViewModels
{
    public class ConnectViewModel
    {
        public string Name { get; set; }
        public IFormFile Avatar { get; set; }
    }
}
