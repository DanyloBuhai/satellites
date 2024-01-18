using satellites.Data.Models;

namespace satellites.Data.Interfaces
{
    public interface IAllSatellites
    {
        IEnumerable<Satellites> Satellites { get;}
        Satellites getSatel(int satellID);
    }
}
