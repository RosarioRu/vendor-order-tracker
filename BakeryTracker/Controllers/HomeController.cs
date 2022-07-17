using Microsoft.AspNetCore.Mvc;

namespace BakeryTracker.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() { return View(); }

  }
}