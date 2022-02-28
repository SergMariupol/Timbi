using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Timbi.ViewModels;
using Timbi.Data.Models;
using Microsoft.AspNetCore.Identity;


namespace Timbi.Controllers
{
    public class UserAreaController : Controller
    {
        [HttpPost]
        public IActionResult Index(string email)
        {
            return View();
        }
    }
}
