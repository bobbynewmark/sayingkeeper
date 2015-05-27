using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SayingKeeper.Controllers
{
    public class HomeController : Controller
    {
        private List<string> anArrayOfPointlessSayings = new List<string>() {
            "There is a fierce Lion in the street, a fierce Lion",
    "If you meet the Buddha, kill him",
    "Of course, no man is entirely in his right mind at any time.",
    "Don't Panic",
    "The future is already here - it's just not very evenly distributed",
    "The sky above the port was the color of television, tuned to a dead channel.",
    "They'll listen to Reason"};

        public ActionResult Index()
        {
            var r = new Random();
            var i = r.Next(anArrayOfPointlessSayings.Count);
            ViewBag.Saying = anArrayOfPointlessSayings[i];
            return View();
        }
    }
}