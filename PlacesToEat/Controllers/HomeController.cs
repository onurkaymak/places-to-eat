using Microsoft.AspNetCore.Mvc;

namespace PlacesToEat.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}