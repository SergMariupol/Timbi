using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Timbi.Data.Interfaces;
using Timbi.Data.Models;
using Timbi.ViewModels;


namespace Timbi.Controllers
{    public class ConnectController : Controller
    {
        private readonly IAllUserArea IAllUserArea;

        ApplicationContext _context;
        IWebHostEnvironment _appEnvironment;



        public ConnectController(IAllUserArea _IAllUserArea, ApplicationContext context, IWebHostEnvironment appEnvironment)
        {
            IAllUserArea = _IAllUserArea;
            _context = context;
            _appEnvironment = appEnvironment;
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
                UserAreaViewModel.CompanyFact = company;
                UserAreaViewModel.Regions = IAllUserArea.Region;
                UserAreaViewModel.TypeService = IAllUserArea.TypeService;
                UserAreaViewModel.Company = IAllUserArea.Company.Where(i => i.TypeService.TypeServices == UserAreaViewModel.TypeServiceFact &&
                i.Region.RegionCompany == UserAreaViewModel.RegionFact);

                string aa = null ;
                //if(ModelState.IsValid && (UserAreaViewModel.CompanyFact != null))
                var a = IAllUserArea.Company.Where(i => i.NameCompany == UserAreaViewModel.CompanyFact);
                foreach(Company Company in a)
                {
                     aa = Company.NameCompany;
                }


                if (ModelState.IsValid && (aa !=null))
                {
                    UserAreaViewModel.PageOneComplete = true;
                    //return View(UserAreaViewModel);


                    ViewBag.Title = "sss";
                    return RedirectToAction("ConnectPage_two", "Connect", new {  a = UserAreaViewModel });
                }




                return View(UserAreaViewModel);
                //return RedirectToAction("StartPage", "Start");
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



           
        public IActionResult ConnectPage_two(string id)
        {

            return View();
        }

        [HttpPost]
        public IActionResult ConnectPage_two(Connect connect)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("StartPage", "Start");
            }
            else
            {
                return View(connect);
            }                
        }

        public IActionResult ConnectDownload()
        {
            return View(_context.Download.ToList());
        }


        //[HttpPost]
        public IActionResult Create(ConnectViewModel pvm)
        {
            Download person = new Download { Name = pvm.Name };
            if (pvm.Avatar != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(pvm.Avatar.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)pvm.Avatar.Length);
                }
                // установка массива байтов
                person.Avatar = imageData;
            }
            _context.Download.Add(person);
            _context.SaveChanges();

            return RedirectToAction("StartPage","Start");
        }




    }
}
