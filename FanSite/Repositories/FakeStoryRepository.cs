using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FanSite.Models;

namespace FanSite.Repositories
{
    public class FakeStoryRepository : IStoryRepository
    {
        private static List<Story> stories = new List<Story>();
        public IQueryable<Story> Stories
        {
            get { return Stories; }
        }

        public List<Story> StoriesList
        {
            get { return stories; }
        }

        public FakeStoryRepository()
        {
            if (stories.Count == 0)
            {
                SeedData();
            }
        }

        public void AddComment(Story story, Comment comment)
        {
            story.Comments.Add(comment);
        }

        public void AddStory(Story story)
        {
            stories.Add(story);
        }

        public Story GetStoryByTitle(string storyTitle)
        {
            Story story;
            story = stories.First(b => b.StoryTitle == storyTitle);
            return story;
        }

        private void SeedData()
        {
            User u = new User();
            u.Username = "Example";
            u.Email = "example@mail.com";

            Story s = new Story();
            s.StoryTitle = "Example Title";
            s.StoryText = "Example Text";
            s.User = u;

            AddStory(s);
        }
    }
}
