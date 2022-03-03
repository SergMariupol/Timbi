using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Timbi.Data.Models
{
    public class Connect
    {
        
        public int id { get; set; }
        
        [Required(ErrorMessage = "Введите имя")]
        [Display(Name = "ФИО (Название предприятия, учреждения или организации)")]
        public string FIO { get; set; }
        [Required]
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Телефон")]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "Email на который будет предоставляться информация")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "При необходимости вы можете оставить комментарий")]
        public string Comment { get; set; }

        public int NumberCounterWater { get; set; }

        public string SerialPassport { get; set; }

        public bool Lgot { get; set; }

        public string AddressObject { get; set; }

        public string InfoVladelec { get; set; }

        public string TypeObject { get; set; }

        public string TypeConsumer { get; set; }

        public bool PresenceCounter { get; set; }

        public byte[] FirstPassport { get; set; }

        public byte[] PropiskaPassport { get; set; }

        public byte[] PravoSobstven { get; set; }

        public byte[] INN { get; set; }

        public byte[] Dogovor { get; set; }
    }
}
