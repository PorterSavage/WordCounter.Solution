using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {

        [HttpGet("/match")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/match/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/match")]
        public ActionResult WordCounterClass(string word, string sentence, int match)
        {
            WordCounterClass newCount = new WordCounterClass(word, sentence, match);
            newCount.HowManyMatchesDoYouHave(word, sentence);
            return RedirectToAction("Index");
        }
    }
}