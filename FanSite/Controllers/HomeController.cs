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
        public ViewResult StoryForm(Story story)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStory(story);
                Repository.stories.Sort((a, b) => a.StoryTitle.CompareTo(b.StoryTitle));
                IEnumerable<Story> stories = Repository.Stories;
                return View("Stories", stories);
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
                Story s = Repository.GetStoryByTitle(storyTitle);
                User u = new User() { Email = email, Username = username };
                Comment c = new Comment() { CommentText = commentText, User = u };
                s.AddComment(c);
                List<Story> stories = Repository.stories;
                return View("Stories", stories);
            } else
            {
                List<Story> stories = Repository.stories;
                return View("Stories", stories);
            }
        }


        public ViewResult Sources()
        {
            return View();
        }
    }
}
