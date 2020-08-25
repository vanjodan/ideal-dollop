using BoxingChampionship.Providers;
using System.Web.Mvc;

namespace BoxingChampionship.Controllers
{
    public class MainController : Controller
    {
        MainProvider _mainProvider { get; }

        public MainController(MainProvider mainProvider)
        {
            _mainProvider = mainProvider;
        }

        public ActionResult Index()
        {
            return RedirectToAction("Get");
        }

        [HttpGet]
        public ActionResult Get()
        {
            return View(_mainProvider.Get());
        }
    }
}
// todo di rename all rankinMembers to rankinG