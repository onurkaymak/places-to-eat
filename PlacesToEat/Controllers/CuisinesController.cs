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
  }
}