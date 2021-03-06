using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Timbi.Data.Models
{
    public class User_
    {
        [BindNever]
        public int Id { get; set; }


        [Display(Name = "Введите логин")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string LoginUser { get; set; }


        [Display(Name = "Введите пароль")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина фамилии не менее 5 символов")]
        [DataType(DataType.Password)]
        public string Password1 { get; set; }


        [Display(Name = "Введите повторно пароль")]
        [StringLength(20)]
        
        [Required(ErrorMessage = "Длина адреса не менее 5 символов")]
        [Compare("Password1", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]       
        public string Password2 { get; set; }


        [Display(Name = "Введите вашу электронную почту")]
        [StringLength(40)]
        [Required(ErrorMessage = "Длина адреса не менее 5 символов")]
        [EmailAddress]
        public string Mail { get; set; }


        [Display(Name = "Введите ваш номер телефона")]
        //[StringLength(20, ErrorMessage = "Длина адреса не менее 5 символов")]
        //[Required(ErrorMessage = "Длина адреса не менее 5 символов")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}
