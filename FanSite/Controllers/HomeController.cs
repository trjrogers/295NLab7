using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;
using System.Web;

namespace FanSite.Controllers
{
    // 3 new methods: SortStories (1st different return type IEnumerable<Story>), SortComments (2nd different return type List<Comment>), RetrieveStory (3rd different return type Story)
    // 4th different return type, changed StoryForm post method to ActionResult type

    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult History()
        {
            return View();
        }

        public ViewResult Stories()
        {
            List<Story> stories = Repository.stories;
            Repository.stories.Sort((a, b) => a.StoryTitle.CompareTo(b.StoryTitle));
            return View(stories);
        }

        [HttpGet]
        public ViewResult StoryForm()
        {
            ViewData["Header"] = "Leave Your Story About The Joker";
            return View();
        }

        [HttpPost]
        public ActionResult StoryForm(Story story)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStory(story);
                //Repository.stories.Sort((a, b) => a.StoryTitle.CompareTo(b.StoryTitle));
                IEnumerable<Story> stories = SortStories(Repository.stories);
                return RedirectToAction("Stories", stories);
            } else
            {
                return View();
            }
        }

        // Creates a new comment using passed parameter
        // Returns CommentForm View and binds Comment c in the model

        public ViewResult CommentForm(string title) 
        {
            ViewBag.NameOfStory = title;
            return View("CommentForm", HttpUtility.HtmlDecode(title));
        }

        [HttpPost]
        public ViewResult CommentForm(string storyTitle, string username, string email, string commentText)
        {
            if (ModelState.IsValid)
            {
                Story s = RetrieveStory(storyTitle);
                User u = new User() { Email = email, Username = username };
                Comment c = new Comment() { CommentText = commentText, User = u };
                s.AddComment(c);
                List<Story> stories = Repository.stories;
                foreach(Story story in stories)
                {
                    SortComments(story.Comments);
                }
                return View("Stories", stories);
            } else
            {
                List<Story> stories = Repository.stories;
                return View("Stories", stories);
            }
        }

        public IEnumerable<Story> SortStories(IEnumerable<Story> stories)
        {
            Repository.stories.Sort((a, b) => a.StoryTitle.CompareTo(b.StoryTitle));
            IEnumerable<Story> s = Repository.Stories;
            return s;
        }

        public List<Comment> SortComments(List<Comment> c)
        {
            c.Sort((a, b) => a.CommentText.CompareTo(b.CommentText));
            return c;
        }


        public ViewResult Sources()
        {
            return View();
        }

        public Story RetrieveStory(string storyTitle)
        {
            return Repository.GetStoryByTitle(storyTitle);

        }
    }
}
