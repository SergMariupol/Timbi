using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Timbi.ViewModels;
using Timbi.Data.Models;
using Microsoft.AspNetCore.Identity;
using Timbi.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Timbi.Controllers
{
    public class UserAreaController : Controller
    {
        private readonly IAllPersonalArea IAllPersonalArea;
    
        //public UserAreaController(IAllPersonalArea _IAllPersonalArea)
        //{
        //    IAllPersonalArea = _IAllPersonalArea;
        //}

        [HttpPost]
        public IActionResult Index()
        {
           // IEnumerable<Main> Main = IAllPersonalArea.Main.Where(i => i.UserName == User.Identity.Name);

             


            return View();
        }
    }
}
