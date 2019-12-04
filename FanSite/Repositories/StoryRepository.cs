using System.Collections.Generic;
using System.Linq;
using FanSite.Models;
using FanSite.Repositories;

namespace FanSite.Models
{
    public class StoryRepository : IStoryRepository
    {
        public static List<Story> stories = new List<Story>();
        public static List<OnlineMediaModel> online = new List<OnlineMediaModel>();
        public static List<PhysicalMediaModel> physical = new List<PhysicalMediaModel>();

        //private AppDbContext context;

        public StoryRepository(AppDbContext appDbContext)
        {
            //if (stories.Count == 0)
            //{
            //    SeedData();
            //}
            //context = appDbContext;
        }

        public IQueryable<Story> Stories
        {
            get
            {
                //return context.Stories;
                return Stories;
            }
        }

        public List<Story> StoriesList
        {
            get { return stories; }
        }

        public IEnumerable<PhysicalMediaModel> Physical
        {
            get
            { return physical; }
        }

        public IEnumerable<OnlineMediaModel> Online
        {
            get { return online; }
        }

        public List<Story> ListStories
        {
            get
            {
                return stories;
            }
        }

        public void AddStory(Story story)
        {
            //stories.Add(story);
            //context.Stories.Add(story);
            //context.SaveChanges();
            stories.Add(story);
        }

        public void AddComment(Story story, Comment comment)
        {
            story.Comments.Add(comment);
        }

        public Story GetStoryByTitle(string storyTitle)
        {
            Story story;
            //story = context.Stories.First(b => b.StoryTitle == storyTitle);
            //story = Stories.First(b => b.StoryTitle == storyTitle);
            story = stories.First(b => b.StoryTitle == storyTitle);
            return story;
            //return StoryRepository.stories.Find(x => x.StoryTitle == storyTitle);
        }

        //public void AddOnline(OnlineMediaModel o)
        //{
        //    online.Add(o);
        //}

        //public void AddPhysical(PhysicalMediaModel p)
        //{
        //    physical.Add(p);
        //}

        //private void SeedData()
        //{
        //    User u = new User();
        //    u.Username = "Example";
        //    u.Email = "example@mail.com";

        //    Story s = new Story();
        //    s.StoryTitle = "Example Title";
        //    s.StoryText = "Example Text";
        //    s.User = u;

        //    AddStory(s);
        //}
    }
}
