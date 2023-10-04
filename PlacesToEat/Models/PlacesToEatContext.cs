using Microsoft.EntityFrameworkCore;

namespace PlacesToEat.Models
{
  public class PlacesToEatContext : DbContext
  {
    public DbSet<Cuisine> Cuisines { get; set; }
    // public DbSet<Restaurant> Restaurants { get; set; }

    public PlacesToEatContext(DbContextOptions options) : base(options) { }
  }
}