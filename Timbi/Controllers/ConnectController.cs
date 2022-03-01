using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timbi.Data.Interfaces;
using Timbi.Data.Models;
using Timbi.ViewModels;

namespace Timbi.Controllers
{    public class ConnectController : Controller
    {
        private readonly IAllUserArea IAllUserArea;
        public ConnectController(IAllUserArea _IAllUserArea)
        {
            IAllUserArea = _IAllUserArea;
        }

        public IActionResult ConnectPage()
        {
            UserAreaViewModel UserArea = new UserAreaViewModel();

            UserArea.Regions = IAllUserArea.Region;

            return View(UserArea);
        }

        [HttpPost]
        public IActionResult ConnectPage_two(UserAreaViewModel UserAreaViewModel)
        {
            return View();
        }
    }
}
