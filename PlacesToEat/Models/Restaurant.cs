namespace PlacesToEat.Models
{
  public class Restaurant
  {
    public string Name { get; set; }
    public int Id { get; set; }
    public int CuisineId { get; set; }
    public string Description { get; set; }
    public Cuisine Cuisine { get; set; }

    //add price later? it is in the database
  }
}