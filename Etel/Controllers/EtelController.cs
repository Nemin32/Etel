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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(this.repository.Read());
        }
    }
}
