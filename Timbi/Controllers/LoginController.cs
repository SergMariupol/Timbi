using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timbi.Data.Interfaces;
using Timbi.Data.Models;
//using Timbi.ViewModels;

namespace Timbi.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAllRegistration IAllRegistration;
        private readonly IAllPersonalArea IAllPersonalArea;
        private User User;

        public LoginController(IAllRegistration IAllRegistration, IAllPersonalArea IAllPersonalArea)
        {
            this.IAllRegistration = IAllRegistration;
            this.IAllPersonalArea = IAllPersonalArea;
        }

        public IActionResult LoginWindow()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginWindow(Login Login)
        {
            IEnumerable<User> UserList;

            UserList = IAllRegistration.UserList.Where(i => i.LoginUser == Login.LoginUser  &&  i.Password1 == Login.Password);  
            
            if (UserList == null || !UserList.Any())
            {
                return View();
            }
                else
            {
                User = UserList.FirstOrDefault<User>();

                return RedirectToAction("PersonalArea");
            }
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Операция успешна";
            return View();
        }
        public IActionResult PersonalArea()
        {
            IEnumerable<Main> MainList = IAllPersonalArea.Main.Where(i => i.idUser == User.Id);




            //ViewBag.Message = "Операция успешна";
            return View();
        }

    }
}


