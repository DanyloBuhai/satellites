using Microsoft.AspNetCore.Mvc;
using satellites.Data.Interfaces;

namespace satellites.Controllers
{
    public class ListController : Controller
    {
        private readonly IAllSatellites _allSatelites;
        private readonly IPlanets _allPlanets;

        public ListController(IAllSatellites allSatelites, IPlanets allPlanets)
        {
            _allSatelites = allSatelites;
            _allPlanets = allPlanets;
        }

        public ViewResult ListSatellites()
        {
            ViewBag.Title = "Супутники";
            var satellites = _allSatelites.Satellites;
            return View(satellites);
        }
        public ViewResult ListPlanets()
        {
            ViewBag.Title = "Планети";
            var planets = _allPlanets.AllPlanets;
            return View(planets);
        }

        [HttpGet]
        public ActionResult Planet(int id)
        {
            var planet = _allPlanets.getPlanet(id);
            var satellites = _allSatelites.Satellites;
            ViewBag.Planet = planet;
            ViewBag.Satellites = satellites;
            ViewBag.Title = planet.planet_name;
            return View(satellites);
        }

        [HttpGet]
        public ActionResult Satellite(int id)
        {
            var satellite = _allSatelites.getSatel(id);
            var planets = _allPlanets.AllPlanets;
            ViewBag.Satellite = satellite;
            ViewBag.Planets = planets;
            ViewBag.Title = satellite.satellite_name;
            return View(satellite);
        }
    }
}
