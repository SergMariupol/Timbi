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

        public string img { get; set; }

        public TypeService TypeService { get; set; }

        public Region Region { get; set; }
    }
    public class TypeService
    {
        public int id { get; set; }

        public string TypeServices { get; set; }

        //public Company Company { get; set; }
    }
    public class Region
    {
        public int id { get; set; }

        public string RegionCompany { get; set; }

        //public Company Company { get; set; }
    }
}
