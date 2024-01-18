using satellites.Data.Interfaces;
using satellites.Data.Models;

namespace satellites.Data.Repository
{
    public class PlanetsRepository : IPlanets
    {
        private readonly AppDbContent appDbContent;

        public PlanetsRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Planets> AllPlanets => appDbContent.Planet;

        public Planets getPlanet(int planetID) => appDbContent.Planet.FirstOrDefault(p => p.planet_id == planetID);
    }
}
