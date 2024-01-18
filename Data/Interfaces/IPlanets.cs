using satellites.Data.Models;

namespace satellites.Data.Interfaces
{
    public interface IPlanets
    {
        IEnumerable<Planets> AllPlanets { get; }

        Planets getPlanet(int planetID);
    }
}
