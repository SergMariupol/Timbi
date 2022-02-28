using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timbi.Data.Interfaces;
using Timbi.Data.Models;
using Timbi.ViewModels;


namespace Timbi.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAllRegistration IAllRegistration;
        private readonly IAllPersonalArea IAllPersonalArea;
        
        

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
            IEnumerable<User_> UserList;
            
            UserList = IAllRegistration.UserList.Where(i => i.LoginUser == Login.LoginUser  &&  i.Password1 == Login.Password);  
            
            if (UserList == null || !UserList.Any())
            {
                return View();
            }
                else
            {
                User_ a = UserList.FirstOrDefault<User_>();
                return RedirectToAction("PersonalArea", new { c = a.Id });
            }
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Операция успешна";
            return View();
        }
        public IActionResult PersonalArea(int c)
        {
            IEnumerable<Main> MainList = IAllPersonalArea.Main.Where(i => i.idUser == c);

            PersonalAreaViewModel PerArea = new PersonalAreaViewModel();
            PerArea.MainTable = MainList;
            return View(PerArea);
        }

    }
}


