using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Timbi.Data.Interfaces;
using Timbi.Data.Models;
//using Timbi.ViewModels;


namespace Timbi.Controllers
{
    public class StartController : Controller
    {
        public IActionResult StartPage()
        {      
        return View();
        }
    }
}
