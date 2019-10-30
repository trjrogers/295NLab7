using Microsoft.AspNetCore.Mvc;
using FanSite.Models;
using System.Collections.Generic;

namespace FanSite.Controllers
{
    public class SourcesController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult PhysicalMedia()
        {
            if (Repository.physical.Count != 2)
            {
                //< h2 >< a href = "https://www.dccomics.com/comics/batman-facsimile-edition-2019/batman-251-facsimile-edition-1" > Buy comics with the Joker</ a ></ h2 >
                PhysicalMediaModel a = new PhysicalMediaModel("Batman #251", "Look out, Gotham! The Joker's back in town!", "https://www.dccomics.com/comics/batman-facsimile-edition-2019/batman-251-facsimile-edition-1");
                PhysicalMediaModel b = new PhysicalMediaModel("The Killing Joke", "Looking to prove that any man can be pushed past his breaking point to madness, the Joker attempts to drive Commissioner Gordon insane. Refusing to give up, Gordon struggles to maintain his sanity with the help of Batman in a desperate effort to best the madman.", "https://www.dccomics.com/graphic-novels/batman-noir-the-killing-joke");

                Repository.physical.Add(b);
                Repository.physical.Add(a);

                List<PhysicalMediaModel> physicals = Repository.physical;
                physicals.Sort((x, y) => x.Title.CompareTo(y.Title));
                return View(physicals);
            } else
            {
                List<PhysicalMediaModel> physicals = Repository.physical;
                physicals.Sort((x, y) => x.Title.CompareTo(y.Title));
                return View(physicals);
            }
        }

        public ViewResult OnlineMedia()
        {
            if (Repository.online.Count != 2)
            {
                OnlineMediaModel a = new OnlineMediaModel("DC Comics", "Learn more about the Joker from the publisher.", "https://www.dccomics.com/characters/joker");
                OnlineMediaModel b = new OnlineMediaModel("Wikipedia", "Learn more about the Joker from fans.", "https://en.wikipedia.org/wiki/Joker_(character)");

                Repository.online.Add(b);
                Repository.online.Add(a);

                List<OnlineMediaModel> onlines = Repository.online;
                onlines.Sort((x, y) => x.Title.CompareTo(y.Title));

                return View(onlines);
            } else
            {
                List<OnlineMediaModel> onlines = Repository.online;
                onlines.Sort((x, y) => x.Title.CompareTo(y.Title));

                return View(onlines);
            }
        }

        [HttpGet]
        public ViewResult Home()
        {
            return View();
        }
    }
}