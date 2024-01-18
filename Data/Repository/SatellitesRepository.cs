using Microsoft.EntityFrameworkCore;
using satellites.Data.Interfaces;
using satellites.Data.Models;
using System.Reflection.Metadata;

namespace satellites.Data.Repository
{
    public class SatellitesRepository : IAllSatellites
    {

        private readonly AppDbContent appDbContent;

        public SatellitesRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Satellites> Satellites => appDbContent.Satelite.Include(c=>c.planet_id);

       

        public Satellites getSatel(int satellID) => appDbContent.Satelite.FirstOrDefault(p => p.satellite_id == satellID);

    }
}
