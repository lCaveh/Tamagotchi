using Microsoft.AspNetCore.Mvc;

namespace TamagotchiSpace.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
