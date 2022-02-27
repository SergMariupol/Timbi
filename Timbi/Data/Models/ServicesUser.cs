using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Timbi.Data.Models
{
    public class ServicesUser
    {
        public int id { get; set; }

        public int idUser { get; set; }

        public int idServices { get; set; }


    }
}
