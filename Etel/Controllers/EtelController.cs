using Etel.Data;
using Etel.Models;
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

        [HttpPost]
        public IActionResult Index(EtelClass model)
        {
            if (model == null || !ModelState.IsValid)
            {
                return View();
            }

            this.repository.Create(model);
            return View(null);
        }

        [HttpGet]
        public IActionResult List(string kategoria)
        {
            if (kategoria == null)
            {
                var cucc = this.repository.Read();
                return View(cucc);
            }

            var etelek = this.repository.Read().Where(e => e.Kategoria == kategoria);
            return View(etelek);
        }
    }
}
