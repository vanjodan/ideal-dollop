using BoxingChampionship.Models;
using BoxingChampionship.Providers;
using System;
using System.Web.Mvc;

namespace BoxingChampionship.Controllers
{
    public class BattleController : Controller
    {
        BattleService _battleService { get; }
        BattleProvider _battleProvider { get; }

        public BattleController(BattleService battleService, BattleProvider battleProvider)
        {
            _battleService = battleService;
            _battleProvider = battleProvider;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return View(_battleProvider.Get());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Battle battle)
        {
            _battleService.Create(battle);

            return RedirectToAction("Create");
        }

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            _battleService.Delete(id);

            return RedirectToAction("Get");
        }
    }
}
