using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timbi.Data.Models
{
    public class Company
    {
        public int id { get; set; }

        public string NameCompany { get; set; }

        public int RegionCompany { get; set; }

        public string img { get; set; }
    }
}
