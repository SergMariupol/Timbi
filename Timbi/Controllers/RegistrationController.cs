using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timbi.Data.Interfaces;
using Timbi.Data.Models;
//using Timbi.ViewModels;

namespace Web_interface.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IAllRegistration IAllRegistration;

        public RegistrationController(IAllRegistration allRegistration)
        {
            this.IAllRegistration = allRegistration;

        }

        //private readonly IAllOrders _allOrders;

        //public OrderListController(IAllOrders allOrders)
        //{
        //    _allOrders = allOrders;
        //}


        public IActionResult RegistrationWindow()
        {         
            return View();
        }

        [HttpPost]
        public IActionResult RegistrationWindow(User User)
        {
            IAllRegistration.CreateUser(User);
            return RedirectToAction("Complete");
        }

        public IActionResult Complete()
        {
        ViewBag.Message = "Регистрация успешна";
        return View();
        }

        public IActionResult RegisterWindowRegister()
        {
            return View();
        }
    }

}

