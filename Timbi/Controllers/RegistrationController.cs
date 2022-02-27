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
    public class RegistrationController : Controller
    {
        private readonly IAllRegistration IAllRegistration;

        public RegistrationController(IAllRegistration allRegistration)
        {
            this.IAllRegistration = allRegistration;

        }

        public IActionResult RegistrationWindow()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrationWindow(User User)
        {
            if (ModelState.IsValid)
            {
                IAllRegistration.CreateUser(User);
                return RedirectToAction("Complete");
            }
            else
                return View();
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Регистрация успешна";
            return View();
        }
    }
}


