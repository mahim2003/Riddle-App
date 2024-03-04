using Microsoft.AspNetCore.Mvc;

namespace Riddle_App.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
