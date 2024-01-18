using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace satellites.Data.Models
{
    public class Satellites
    {
        [Key]
        public int satellite_id { get; set; }

        public string satellite_name { get; set; }
        public string discovery_date { get; set; }
        public double diameter { get; set; }
        public double turnover_period { get; set; }
        public bool atmosphere { get; set; }
        public string notes { get; set; }
        public string longnote { get; set; }
        public string img { get; set; }

        public virtual Planets planet_id { get; set; }
    }
}
