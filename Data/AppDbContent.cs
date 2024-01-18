
using Microsoft.EntityFrameworkCore;
using satellites.Data.Models;
using System.Reflection.Metadata;

namespace satellites.Data
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
        {

        }
        public DbSet<Satellites> Satelite { get; set; }
        public DbSet<Planets> Planet { get; set; }
    }
}
