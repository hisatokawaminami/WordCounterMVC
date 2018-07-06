using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/wordcounter/play")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/wordcounter/count")]
    public ActionResult Result()
    {
        RepeatCounter newItem = new RepeatCounter(Request.Form["new-word"], Request.Form["new-sentence"]);

      return View(newItem);
    }
  }
}
