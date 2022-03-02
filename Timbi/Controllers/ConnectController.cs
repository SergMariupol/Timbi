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

        public IActionResult ConnectPage(string? id)
        {
            UserAreaViewModel UserArea = new UserAreaViewModel();

            UserArea.Regions = IAllUserArea.Region;
            UserArea.TypeService = IAllUserArea.TypeService;
            UserArea.Company = IAllUserArea.Company;
            UserArea.CompanyFact = id;

            return View(UserArea);
        }

        [HttpPost]
        public IActionResult ConnectPage(UserAreaViewModel UserAreaViewModel, string? company)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("StartPage", "Start");
            }
            else
            {
                UserAreaViewModel.CompanyFact = company;
                UserAreaViewModel.Regions = IAllUserArea.Region;
                UserAreaViewModel.TypeService = IAllUserArea.TypeService;
                UserAreaViewModel.Company = IAllUserArea.Company;

                return View(UserAreaViewModel);

            }
        }

        public IActionResult Logic()
        {
            return RedirectToAction("StartPage", "Start");
        }






            [HttpPost]
        public IActionResult ConnectPage_two(UserAreaViewModel UserAreaViewModel)
        {
            //if (ModelState.IsValid)
            //{
            //    return RedirectToAction("StartPage", "Start");
            //}
            //else
            //{
            //    return View(UserAreaViewModel);

            //}
            return View();
        }
    }
}
