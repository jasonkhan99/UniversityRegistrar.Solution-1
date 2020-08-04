using Microsoft.AspNetCore.Mvc;

namespace Registrar.Models
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