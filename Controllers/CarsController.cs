using Microsoft.AspNetCore.Mvc;

namespace CarsApp.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
