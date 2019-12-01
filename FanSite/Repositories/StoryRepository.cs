using System.Collections.Generic;
using System.Linq;
using FanSite.Models;
using FanSite.Repositories;

namespace FanSite.Models
{
    public class StoryRepository : IStoryRepository
    {
        //public static List<Story> stories = new List<Story>();
        public static List<OnlineMediaModel> online = new List<OnlineMediaModel>();
        public static List<PhysicalMediaModel> physical = new List<PhysicalMediaModel>();

        private AppDbContext context;

        public IQueryable<Story> Stories
        {
            get
            {
                return context.Stories;
            }
        }

        public StoryRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
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

        //public static IEnumerable<Story> Stories
        //{
        //    get
        //    {
        //        return stories;
        //    }
        //}

        public void AddStory(Story story)
        {
            //stories.Add(story);
            context.Stories.Add(story);
            context.SaveChanges();
        }

        public Story GetStoryByTitle(string storyTitle)
        {
            Story story;
            story = context.Stories.First(b => b.StoryTitle == storyTitle);
            return story;
            //return StoryRepository.stories.Find(x => x.StoryTitle == storyTitle);
        }

        public void AddOnline(OnlineMediaModel o)
        {
            online.Add(o);
        }

        public void AddPhysical(PhysicalMediaModel p)
        {
            physical.Add(p);
        }
    }
}
