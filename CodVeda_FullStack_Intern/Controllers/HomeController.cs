// Home Controller
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks; // Required for Task

namespace CodVeda_FullStack_Intern.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {  
            return View();
        }
    }
}
