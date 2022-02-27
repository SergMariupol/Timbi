using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Timbi.Data.Models
{
    public class Login
    {
        [Display(Name = "Введите логин")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string LoginUser { get; set; }

        [Display(Name = "Введите пароль")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина фамилии не менее 5 символов")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
