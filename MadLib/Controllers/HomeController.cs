using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }
    LibsVariable libsVariable = new LibsVariable();

    [Route("/Libs")]
    public ActionResult Libs(string noun, string verb, string adjective, string animal)
    {
    LibsVariable libsVariable = new LibsVariable();
      libsVariable.Noun = noun;
      libsVariable.Verb = verb;
      libsVariable.Adjective = adjective;
      libsVariable.Animal = animal;
      return View(libsVariable);
    }

    [Route("/Jungle")]
    public ActionResult Jungle(string noun, string verb, string adjective, string animal)
    {
      libsVariable.Noun = noun;
      libsVariable.Verb = verb;
      libsVariable.Adjective = adjective;
      libsVariable.Animal = animal;
      return View("Jungle", libsVariable);
    }
    [Route("/Zoo")]
    public ActionResult Zoo(string noun, string verb, string adjective, string animal)
    {
      libsVariable.Noun = noun;
      libsVariable.Verb = verb;
      libsVariable.Adjective = adjective;
      libsVariable.Animal = animal;
      return View("Zoo", libsVariable);
    }
    [Route("/Monkey")]
    public ActionResult Monkey(string noun, string verb, string adjective, string animal)
    {
      libsVariable.Noun = noun;
      libsVariable.Verb = verb;
      libsVariable.Adjective = adjective;
      libsVariable.Animal = animal;
      return View("Monkey", libsVariable);
    }
  }
}