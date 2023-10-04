using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Mvc;
using PlacesToEat.Models;
using System.Linq;

namespace PlacesToEat.Controllers
{
  public class CuisinesController : Controller
  {
    private readonly PlacesToEatContext _db;

    public CuisinesController(PlacesToEatContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Cuisine> model = _db.Cuisines.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Cuisine cuisine)
    {
      _db.Cuisines.Add(cuisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}