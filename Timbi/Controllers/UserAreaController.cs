using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Timbi.ViewModels;
using Timbi.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using Data_Timbi.Data.Interfaces;
using Data_Timbi.Data.Models;
using Data_Timbi.Data;

namespace Timbi.Controllers
{
    public class UserAreaController : Controller
    {

        [HttpPost]
        public IActionResult Index()
        {
            AppDbContent context = new AppDbContent();

            Main a = new Main();

            a.UserName = "Asd";

            context.Main.Add(a);
            context.SaveChanges();

            //IEnumerable<Main> Main = IAllPersonalArea.Main.Where(i => i.UserName == User.Identity.Name);
            return View();
        }
    }
}
