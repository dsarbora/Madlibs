using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/madlib")]
    public ActionResult Madlib(string adj1, string adj2, string noun1, string noun2, string verb1, string verb2, string adverb)
    {
      Filler filler = new Filler(adj1, adj2, noun1, noun2, verb1, verb2, adverb);

      return View(filler);
    }

  }
}
