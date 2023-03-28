using Microsoft.AspNetCore.Mvc;

namespace Etel.Controllers
{
    public class EtelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
