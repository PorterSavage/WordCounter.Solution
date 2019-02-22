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

        // [HttpPost("/match")]
        // {

        // }
    }
}