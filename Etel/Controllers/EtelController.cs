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

        [OutputCache(Duration = 5, VaryByParam = "none")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(EtelClass model, IFormFile picturedata)
        {
            if (model == null || !ModelState.IsValid)
            {
                return View();
            }

            using (var stream = picturedata.OpenReadStream())
            {
                byte[] buffer = new byte[picturedata.Length];
                stream.Read(buffer, 0, (int)picturedata.Length);

                model.Data = buffer;
                model.ContentType = picturedata.ContentType;
            }

            this.repository.Create(model);
            return View(null);
        }

        [HttpGet]
        [OutputCache(Duration = 5, VaryByParam = "none")]
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
        public IActionResult GetImage(string id)
        {
            var etel = repository.ReadFromId(id);
            if (etel.ContentType != null && etel.ContentType.Length > 3)
            {
                return new FileContentResult(etel.Data, etel.ContentType);
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
