using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using Timbi.Data.Models;
using Timbi.Data.Interfaces;
using Timbi.ViewModels;

namespace Timbi.Controllers
{
    public class UserAreaController : Controller
    {
        private readonly IAllUserArea IAllUserArea;
        public UserAreaController(IAllUserArea _IAllUserArea)
        {
            IAllUserArea = _IAllUserArea;
        }



        [HttpPost]
        public IActionResult Index()
        {
            UserAreaViewModel UserArea = new UserAreaViewModel();

            UserArea.Regions = IAllUserArea.Region;

            return View(UserArea);
        }
    }
}
