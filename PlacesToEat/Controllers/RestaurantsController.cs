using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PlacesToEat.Models;
using System.Collections.Generic;
using System.Linq;

namespace PlacesToEat.Controllers
{
  public class RestaurantsController : Controller
  {
    private readonly PlacesToEatContext _db;

    public RestaurantsController(PlacesToEatContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Restaurant> model = _db.Restaurants
                              .Include(restaurant => restaurant.Cuisine)
                              .ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Restaurant restaurant)
    {
      if (restaurant.CuisineId == 0)
      {
        return RedirectToAction("Create");
      }
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}