using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace satellites.Data.Models
{
    public class Planets
    {
        [Key]
        public int planet_id { get; set; }
        public string planet_name { get; set; }
        public string img { get; set; }

        public string note { get; set; }
        public List<Satellites> satellit { get; set; }
    }
}
