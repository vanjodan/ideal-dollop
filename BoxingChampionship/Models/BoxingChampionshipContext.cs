using System.Data.Entity;

namespace BoxingChampionship.Models
{
    public class BoxingChampionshipContext : DbContext
    {
        public DbSet<Boxer> Boxers { get; set; }
        public DbSet<Battle> Battles { get; set; }
    }
}