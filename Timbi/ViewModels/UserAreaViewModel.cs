using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Timbi.Data.Models;

namespace Timbi.ViewModels
{
    public class UserAreaViewModel
    {
        public IEnumerable<Main> Main { get; set; }

        public IEnumerable<Region> Regions { get; set; }

        public IEnumerable<TypeService> TypeService { get; set; }

        public Region Region { get; set; }

        public string[] Status = new[] {"Для дома", "Для бизнеса"};

        [Required(ErrorMessage ="Заполните поле")]
        public string StatusFact { get; set; }

        public string RegionFact { get; set; }

        [Required(ErrorMessage = "Заполните поле")]
        public string TypeServiceFact { get; set; }
        
    }
}
