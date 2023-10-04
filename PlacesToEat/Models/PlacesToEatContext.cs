using Microsoft.EntityFrameworkCore;

namespace PlaceToEat.Models
{
  public class PlaceToEatContext : DbContext
  {
    public DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}