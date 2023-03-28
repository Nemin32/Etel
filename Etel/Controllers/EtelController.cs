using Etel.Data;
using Microsoft.AspNetCore.Mvc;

namespace Etel.Controllers
{
    public class EtelController : Controller
    {
        IEtelRepository repository;

        public EtelController(IEtelRepository repository)
        {
            this.repository = repository;
        }

        [OutputCache(Duration = 5, VaryByParam = "none")]
        public IActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 5, VaryByParam = "none")]
        public IActionResult List()
        {
            return View(this.repository.Read());
        }
    }
}
