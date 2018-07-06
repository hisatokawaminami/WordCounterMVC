using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("wordController/play")]
    public ActionResult CreateForm()
    {
      return View();
    }
  }
}
