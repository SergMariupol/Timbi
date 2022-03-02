using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timbi.Data.Models
{
    public class Connect
    {
        public int id { get; set; }

        public string FIO { get; set; }

        public string Adres { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }

        public string Comment { get; set; }
    }
}
