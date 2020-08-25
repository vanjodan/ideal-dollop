using BoxingChampionship.Models;
using System.Web.Mvc;

namespace BoxingChampionship.Controllers
{
    public class BoxerController : Controller
    {
        BoxerService _boxerService { get; }

        public BoxerController(BoxerService boxerService)
        {
            _boxerService = boxerService;
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Boxer boxer)
        {
            _boxerService.Create(boxer);

            return RedirectToAction("Create");
        }
    }
}
